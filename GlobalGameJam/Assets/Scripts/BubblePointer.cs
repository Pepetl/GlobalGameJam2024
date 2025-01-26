using System.Collections.Generic;
using UnityEngine;

public class BubblePointer : MonoBehaviour
{
    public Transform firePoint; // Punto de disparo
    public float sensibilidad = 1f; // Sensibilidad para el movimiento de la posici�n

    void Update()
    {
        // Actualizar la posici�n de firePoint con la posici�n del rat�n en la pantalla
        Vector3 posicionMousePantalla = Input.mousePosition;

        // Convertir la posici�n del rat�n de pantalla a mundo
        Vector3 posicionMouseMundo = Camera.main.ScreenToWorldPoint(posicionMousePantalla);

        // Si tu juego es en 2D, aseg�rate de que la z de la posici�n del mouse no cambie
        posicionMouseMundo.z = firePoint.position.z; // Mantener la misma z para que no se desplace hacia adelante o hacia atr�s

        // Asignar la nueva posici�n del rat�n al firePoint
        firePoint.position = posicionMouseMundo;

        // Si el jugador presiona el bot�n de disparo, dispara
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Obt�n un objeto del pool
        GameObject bullet = ObjectPool.Instance.GetPooledObject();

        if (bullet != null)
        {
            // Coloca la bala en el punto de disparo
            bullet.transform.position = firePoint.position;
            bullet.transform.rotation = firePoint.rotation;
            bullet.SetActive(true); // Activa la bala para que empiece a moverse
        }
    }
}
