using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance; // Instancia del pool
    public GameObject objectToPool; // Prefab del objeto a reciclar
    public int poolSize = 10; // Número de objetos que queremos en el pool
    private List<GameObject> pooledObjects; // Lista que contiene los objetos del pool

    void Awake()
    {
     
            Instance = this;
       
    }

    void Start()
    {
        pooledObjects = new List<GameObject>(); // Inicializamos la lista del pool

        // Creamos objetos y los desactivamos
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectToPool); // Creamos el objeto
            obj.SetActive(false); // Lo desactivamos de inmediato
            pooledObjects.Add(obj); // Lo agregamos al pool
        }
    }

    // Método para obtener un objeto del pool
    public GameObject GetPooledObject()
    {
        // Buscamos un objeto inactivo
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i]; // Devolvemos el objeto inactivo
            }
        }

        // Si no hay objetos inactivos, podemos optar por crear uno nuevo
        // pero en este ejemplo, no lo haremos para mantener el pool fijo
        return null;
    }
}
