using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    public float songBpm; // Beats por minuto
    public float secPerBeat; // Segundos por cada beat
    public float songPosition; // Posici�n de la canci�n en segundos
    public float songPositionInBeats; // Posici�n de la canci�n en beats (para comparaci�n con los rangos)
    public float dspSongTime; // Tiempo de reproducci�n de la canci�n desde el inicio (en el AudioSettings)

    public AudioSource song1, song2, song3;

    public static Conductor instance;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        // Calcular el n�mero de segundos por beat
        secPerBeat = 60f / songBpm;

        // Registrar el tiempo cuando la m�sica comienza
        dspSongTime = (float)AudioSettings.dspTime;

        // Comenzar a reproducir la canci�n (puedes elegir una canci�n aqu�)
        PlayMusic(song1);
    }

    void Update()
    {
        // Obtener la posici�n actual de la canci�n en segundos
        songPosition = (float)(AudioSettings.dspTime - dspSongTime);

        // Obtener la posici�n de la canci�n en beats (relaci�n de segundos a beats)
        songPositionInBeats = songPosition / secPerBeat;
    }

    // M�todo para reproducir una canci�n
    void PlayMusic(AudioSource song)
    {
        song.Play();
    }
}

