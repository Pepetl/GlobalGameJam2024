using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public List<float> Notes;

    float minPosition = 10f;  // Segundo 10
    float maxPosition = 13f;
    private List<Vector2> songRanges = new List<Vector2>()
    {
        new Vector2(10f, 11f),  // Rango entre 10 y 13 segundos
        new Vector2(20f, 21f),  // Rango entre 20 y 23 segundos
        new Vector2(30f, 31f)   // Rango entre 30 y 33 segundos
    };

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // Recorremos todos los rangos en la lista
            foreach (var range in songRanges)
            {
                // Verificar si la posición actual de la canción está dentro del rango
                if (Conductor.instance.songPositionInBeats >= range.x && Conductor.instance.songPositionInBeats <= range.y)
                {
                    Debug.Log("La canción está en el rango: " + range.x + " - " + range.y);
                    break;  // Sale del ciclo una vez que encuentra el primer rango coincidente
                }
            }
        }
    }

}