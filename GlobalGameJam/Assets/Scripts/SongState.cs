using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SongManager;

public enum songs
{
    none,
    song1,
    song2,
    song3
}

public class SongState : MonoBehaviour
{
    public List<SongRange> songPlaying = new List<SongRange>();  // Lista para los rangos de la canción que está sonando
    public static SongState instance;
    public static songs currentSong = songs.none;



    private void Start()
    {
        SetSongs(songs.song1);
    }
    // Declaración de las listas de rangos para cada canción
    private List<SongRange> song1RangesList = new List<SongRange>()
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

    private List<SongRange> song2RangesList = new List<SongRange>()
    {
        new SongRange(0f, 1f),
        new SongRange(2f, 3f),
        new SongRange(4f, 5f),
        new SongRange(6f, 7f)
    };

    private List<SongRange> song3RangesList = new List<SongRange>()
    {
        new SongRange(0f, 1f),
        new SongRange(1f, 2f),
        new SongRange(2f, 3f),
        new SongRange(3f, 4f)
    };

    private void Awake()
    {
        instance = this;

        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        currentSong = songs.none;
    }

    // Método para cambiar entre las canciones
    public void SetSongs(songs newState)
    {
        if (currentSong == newState)
        {
            Debug.LogWarning($"El juego ya está en el estado {newState}");
            return;
        }

        currentSong = newState;

        // Asignar rangos de la canción seleccionada
        switch (currentSong)
        {
            case songs.none:
                songPlaying.Clear(); // Limpiar los rangos si no hay canción
                break;

            case songs.song1:
                Conductor.instance.songBpm = 138;
                Conductor.instance.secPerBeat = 2;
                Conductor.instance.song1.Play();

                songPlaying = new List<SongRange>(song1RangesList);  // Asignar los rangos de la canción 1
                break;

            case songs.song2:
                songPlaying = new List<SongRange>(song2RangesList);  // Asignar los rangos de la canción 2
                break;

            case songs.song3:
                songPlaying = new List<SongRange>(song3RangesList);  // Asignar los rangos de la canción 3
                break;

            default:
                songPlaying.Clear();  // Limpiar los rangos si no se encuentra una canción
                break;
        }
    }

    // Método para obtener la canción que se está reproduciendo actualmente
    public songs GetSongs()
    {
        return currentSong;
    }
}
