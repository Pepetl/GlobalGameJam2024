using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    // Instancia única de este pool
    public static ObjectPool Instance;

    // Prefabs para distintos tipos de objetos que puedes asignar
    public List<GameObject> objectPrefabs;  // Lista para diferentes prefabs
    private List<List<GameObject>> pooledObjects;  // Lista de listas para objetos pool

    public int poolSize = 10;  // Número de objetos que queremos por prefab

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        } else
        {
            Destroy(gameObject); // Destruir si ya existe una instancia
        }

        // Inicializamos la lista de pools
        pooledObjects = new List<List<GameObject>>();

        // Creamos un pool para cada prefab
        foreach (var prefab in objectPrefabs)
        {
            var pool = new List<GameObject>();
            for (int i = 0; i < poolSize; i++)
            {
                GameObject obj = Instantiate(prefab);
                obj.SetActive(false);
                pool.Add(obj);
            }
            pooledObjects.Add(pool);
        }
    }

    // Método para obtener un objeto de un pool específico
    public GameObject GetPooledObject(int index)
    {
        if (index < 0 || index >= pooledObjects.Count) return null;

        var pool = pooledObjects[index];

        for (int i = 0; i < pool.Count; i++)
        {
            if (!pool[i].activeInHierarchy)
            {
                return pool[i];
            }
        }

        return null;  // Si no hay objetos inactivos, devolver null
    }
}
