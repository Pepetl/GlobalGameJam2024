using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    public float songBpm; // Beats por minuto
    public float secPerBeat; // Segundos por cada beat
    public float songPosition; // Posición de la canción en segundos
    public float songPositionInBeats; // Posición de la canción en beats (para comparación con los rangos)
    public float dspSongTime; // Tiempo de reproducción de la canción desde el inicio (en el AudioSettings)

    public AudioSource song1, song2, song3;

    public static Conductor instance;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        // Calcular el número de segundos por beat
        secPerBeat = 60f / songBpm;

        // Registrar el tiempo cuando la música comienza
        dspSongTime = (float)AudioSettings.dspTime;

        // Comenzar a reproducir la canción (puedes elegir una canción aquí)
        PlayMusic(song1);
    }

    void Update()
    {
        // Obtener la posición actual de la canción en segundos
        songPosition = (float)(AudioSettings.dspTime - dspSongTime);

        // Obtener la posición de la canción en beats (relación de segundos a beats)
        songPositionInBeats = songPosition / secPerBeat;
    }

    // Método para reproducir una canción
    void PlayMusic(AudioSource song)
    {
        song.Play();
    }
}

