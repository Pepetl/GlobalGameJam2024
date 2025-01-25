using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour
{
    // Clase SongRange, para almacenar los rangos de la canción
    public class SongRange
    {
        public float start;   // Inicio del rango en segundos
        public float end;     // Fin del rango en segundos
        public bool processed; // Indica si este rango ya ha sido procesado

        // Constructor
        public SongRange(float start, float end)
        {
            this.start = start;
            this.end = end;
            this.processed = false;  // Inicialmente no procesado
        }
    }

    // Lista que contiene los rangos de la canción (renombrada a songRangesList)
    public List<SongRange> songRangesList = new List<SongRange>()
    {
      new SongRange(0f, 1f),
        new SongRange(4f, 5f),
        new SongRange(8f, 9f),
        new SongRange(12f, 13f),
        new SongRange(16f, 17f),
        new SongRange(20f, 21f),
        new SongRange(24f, 25f),
        new SongRange(28f, 29f),
        new SongRange(32f, 33f),
        new SongRange(36f, 37f),
        new SongRange(40f, 41f),
        new SongRange(44f, 45f),
        new SongRange(48f, 49f),
        new SongRange(52f, 53f),
        new SongRange(56f, 57f),
        new SongRange(60f, 61f),
        new SongRange(64f, 65f),
        new SongRange(68f, 69f),
        new SongRange(72f, 73f),
        new SongRange(76f, 77f),
        new SongRange(80f, 81f),
        new SongRange(84f, 85f),
        new SongRange(88f, 89f),
        new SongRange(92f, 93f),
        new SongRange(96f, 97f)
    };

    // Update se llama una vez por fotograma
    void Update()
    {
        // Verificar si 'Conductor' está inicializado
        if (Conductor.instance != null && Input.GetButtonDown("Fire1"))
        {
            // Recorremos los rangos de la canción
            foreach (var range in songRangesList)  // Usar el nuevo nombre aquí
            {
                // Comprobar si la posición de la canción está dentro de un rango
                if (Conductor.instance.songPositionInBeats >= range.start && Conductor.instance.songPositionInBeats <= range.end)
                {
                    // Si el rango no ha sido procesado aún
                    if (!range.processed)
                    {
                        Debug.Log("La canción está en el rango: " + range.start + " - " + range.end);
                        ScoreManager.instance.streak++;
                        ScoreManager.instance.scoreMultiplayer();
                        // Marcar este rango como procesado
                        range.processed = true;
                    }
                }
            }
        } else if (Conductor.instance == null)
        {
            // Advertir si 'Conductor' no está inicializado
            Debug.LogWarning("Conductor.instance no está inicializado.");
        }
    }
}
