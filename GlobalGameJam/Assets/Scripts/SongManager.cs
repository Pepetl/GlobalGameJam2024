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
    void Update()
    {
        // Verificar si 'Conductor' está inicializado
        if (Conductor.instance != null && Input.GetButtonDown("Fire1"))
        {
            bool notePressed = false;  // Variable para verificar si la nota fue presionada correctamente

            // Recorremos los rangos de la canción
            foreach (var range in SongState.instance.songPlaying)  // Usar el nuevo nombre aquí
            {
                // Comprobar si la posición de la canción está dentro de un rango
                if (Conductor.instance.songPositionInBeats >= range.start && Conductor.instance.songPositionInBeats <= range.end)
                {
                    // Si el rango no ha sido procesado aún
                    if (!range.processed)
                    {
                        // Asegurarse de que la racha se mantenga solo cuando se acierte
                        Debug.Log("La canción está en el rango: " + range.start + " - " + range.end);

                        // Incrementamos la racha de aciertos y calculamos el puntaje
                        ScoreManager.instance.streak++;
                        ScoreManager.instance.scoreMultiplayer();

                        // Marcar este rango como procesado para que no se repita
                        range.processed = true;

                        // Notificar que la nota fue correctamente presionada
                        notePressed = true;
                    }
                }
            }

            // Si la nota no fue presionada correctamente (el jugador está fuera del rango)
            if (!notePressed)
            {
                // Restablecer la racha a 0 en caso de fallo
                ScoreManager.instance.streak = 0;
                Debug.Log("¡Fallaste! La racha ha sido reseteada.");
            }
        } else if (Conductor.instance == null)
        {
            // Advertir si 'Conductor' no está inicializado
            Debug.LogWarning("Conductor.instance no está inicializado.");
        }
    }

    // Método para restablecer los rangos cuando se reinicia la canción o juego (si es necesario)
    public void ResetRanges()
    {
        foreach (var range in SongState.instance.songPlaying)
        {
            range.processed = false;  // Reinicia todos los rangos a "no procesado"
        }
    }
}
