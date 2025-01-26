using UnityEngine;

public class BubblePointer : MonoBehaviour
{
    public Transform firePoint; // Punto de disparo
    public float sensibilidad = 1f; // Sensibilidad para el movimiento de la posición

    // Índice de la bala en el Object Pool (0 para balas)
    public int bulletIndex = 0; 

    void Update()
    {
        // Actualizar la posición de firePoint con la posición del ratón en la pantalla
        Vector3 posicionMousePantalla = Input.mousePosition;

        // Convertir la posición del ratón de pantalla a mundo
        Vector3 posicionMouseMundo = Camera.main.ScreenToWorldPoint(posicionMousePantalla);

        // Si tu juego es en 2D, asegúrate de que la z de la posición del mouse no cambie
        posicionMouseMundo.z = firePoint.position.z; // Mantener la misma z para que no se desplace hacia adelante o hacia atrás

        // Asignar la nueva posición del ratón al firePoint
        firePoint.position = posicionMouseMundo;

        // Si el jugador presiona el botón de disparo, dispara
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Obtén una bala del pool utilizando el índice correspondiente
        GameObject bullet = ObjectPool.Instance.GetPooledObject(bulletIndex);

        if (bullet != null)
        {
            // Coloca la bala en el punto de disparo
            bullet.transform.position = firePoint.position;
            bullet.transform.rotation = firePoint.rotation;
            bullet.SetActive(true); // Activa la bala para que empiece a moverse
        }
    }
}
