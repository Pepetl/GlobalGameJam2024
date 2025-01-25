using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour
{
    // Clase SongRange, para almacenar los rangos de la canci�n
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

    // Lista que contiene los rangos de la canci�n (renombrada a songRangesList)
    public List<SongRange> songRangesList = new List<SongRange>()
    {
        new SongRange(10f, 11f),  // Rango entre 10 y 11 segundos
        new SongRange(20f, 21f),  // Rango entre 20 y 21 segundos
        new SongRange(30f, 31f)   // Rango entre 30 y 31 segundos
    };

    // Update se llama una vez por fotograma
    void Update()
    {
        // Verificar si 'Conductor' est� inicializado
        if (Conductor.instance != null && Input.GetButtonDown("Fire1"))
        {
            // Recorremos los rangos de la canci�n
            foreach (var range in songRangesList)  // Usar el nuevo nombre aqu�
            {
                // Comprobar si la posici�n de la canci�n est� dentro de un rango
                if (Conductor.instance.songPositionInBeats >= range.start && Conductor.instance.songPositionInBeats <= range.end)
                {
                    // Si el rango no ha sido procesado a�n
                    if (!range.processed)
                    {
                        Debug.Log("La canci�n est� en el rango: " + range.start + " - " + range.end);

                        // Marcar este rango como procesado
                        range.processed = true;
                    }
                }
            }
        } else if (Conductor.instance == null)
        {
            // Advertir si 'Conductor' no est� inicializado
            Debug.LogWarning("Conductor.instance no est� inicializado.");
        }
    }
}
