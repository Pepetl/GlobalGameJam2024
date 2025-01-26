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
        new SongRange(41f,42f),
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
        new SongRange(70f,71f),
        new SongRange(72f, 73f),
        new SongRange(74f,75f),
        new SongRange(76f, 77f),
        new SongRange(78f,79f),
        new SongRange(80f,81f),
        new SongRange(82f,83f),
        new SongRange(84f,85f),
        new SongRange(86f,87f),
        new SongRange(88f,89f),
        new SongRange(90f,91f),
        new SongRange(92f,93f),
        new SongRange(94f,95f),
        new SongRange(96f,97f),
        new SongRange(98f,99f),
        new SongRange(101f,102f),
        new SongRange(103f,104f),
        new SongRange(105f,106f),
        new SongRange(107f, 108f),
        new SongRange(109f,110),
        new SongRange(111f, 112f),
        new SongRange(113f,114f),
        new SongRange(115f,116f),
        new SongRange(117f,118f),
        new SongRange(119f,120f),
        new SongRange(121f,122f),
        new SongRange(123,124f),
        new SongRange(125f,126f),
        new SongRange(127f,128f),
        new SongRange(129f,130f),
        new SongRange(131f,132f),
        new SongRange(133f,134f),
        new SongRange(135f,136f),
        new SongRange(137f,138f),
        new SongRange(139f,140),
        new SongRange(141f, 142f),
        new SongRange(143f,144f),
        new SongRange(145f, 146f),
        new SongRange(147f,148f),
        new SongRange(149f,150),
        new SongRange(151f,152f),
        new SongRange(153f,154f),
        new SongRange(155f,156f),
        new SongRange(157f,158f),
        new SongRange(159f,160),
        new SongRange(161f,162f),
        new SongRange(163f,164f),
        new SongRange(165f,166f),
        new SongRange(167f,168f),
        new SongRange(169f,170f),
        new SongRange(171f,172f),
        new SongRange(173f,174f),
        new SongRange(175f, 176f),
        new SongRange(177f,178f),
        new SongRange(179f, 180f),
        new SongRange(181f,182f),
        new SongRange(183f,184f),
        new SongRange(185f,186f),
        new SongRange(187f,188f),
        new SongRange(189f,190f),
        new SongRange(191f,192f),
        new SongRange(193f,194f),
        new SongRange(195f,196f),
        new SongRange(197f,198f),
        new SongRange(199f,200f),
        new SongRange(201f,202f),
        new SongRange(203f,204f),
        new SongRange(205f,206f),
        new SongRange(207f,208f),
        new SongRange(209f, 210f),
        new SongRange(211f,212f),
        new SongRange(213f, 214f),
        new SongRange(215f,216f),
        new SongRange(217f,218f),
        new SongRange(219f,220f),
        new SongRange(221f,222f),
        new SongRange(223f,224f),
        new SongRange(225f,226f),
        new SongRange(227f,228f),
        new SongRange(230f,231f),
        new SongRange(232f,233f),
        new SongRange(234f,235f),
        new SongRange(236f,237f),
        new SongRange(238f,239f),
        new SongRange(240f,241f),
        new SongRange(242f,243f),
        new SongRange(244f,245f),
        new SongRange(246f,247f),
        new SongRange(248f, 249f),
        new SongRange(250f,251f),
        new SongRange(252f,253f),
        new SongRange(254f,255f),
        new SongRange(256f,257f),
        new SongRange(258f,259f),
        new SongRange(260f,261f),
        new SongRange(262f,263f),
        new SongRange(264f,265f),
        new SongRange(266f,267f),
        new SongRange(268f,269f),
        new SongRange(270f,271f),
        new SongRange(272f,273f),
        new SongRange(274f,275f),


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