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
        new SongRange(2f,3f),
        new SongRange(4f, 5f),
        new SongRange(6f,7f),
        new SongRange(8f, 9f),
        new SongRange(10f,11f),
        new SongRange(12f,13f),
        new SongRange(14f,15f),
        new SongRange(16f,17f),
        new SongRange(18f,19f),
        new SongRange(20f,21f),
        new SongRange(22f,23f),
        new SongRange(24f,25f),
        new SongRange(26f,27f),
        new SongRange(28f,29f),
        new SongRange(30f,31f),
        new SongRange(32f,33f),
        new SongRange(34f,35f),
        new SongRange(36f,37f),
        new SongRange(38f, 39f),
        new SongRange(40f,42f),
        new SongRange(42f, 43f),
        new SongRange(44f,45f),
        new SongRange(46f,47f),
        new SongRange(48f,49f),
        new SongRange(50f,51f),
        new SongRange(52f,53f),
        new SongRange(54f,55f),
        new SongRange(56f,57f),
        new SongRange(58f,59f),
        new SongRange(60f,61f),
        new SongRange(62f,63f),
        new SongRange(64f,65f),
        new SongRange(66f,67f),
        new SongRange(68f,69f),


    };

    private List<SongRange> song2RangesList = new List<SongRange>()
    {
        new SongRange(2f,3f),
 
        new SongRange(4f, 5f),

        new SongRange(6f,7f),

        new SongRange(8f, 9f),

        new SongRange(10f,11f),
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
                Conductor.instance.songBpm = 90;
                Conductor.instance.secPerBeat = 2;
                Conductor.instance.song1.Play();

                songPlaying = new List<SongRange>(song1RangesList);  // Asignar los rangos de la canción 1
                break;

            case songs.song2:
                Conductor.instance.songBpm = 100;
                Conductor.instance.secPerBeat = 2;
                Conductor.instance.song2.Play();

                songPlaying = new List<SongRange>(song2RangesList);  // Asignar los rangos de la canción 2
                break;

            case songs.song3:
                Conductor.instance.songBpm = 110;
                Conductor.instance.secPerBeat = 2;
                Conductor.instance.song3.Play();

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
