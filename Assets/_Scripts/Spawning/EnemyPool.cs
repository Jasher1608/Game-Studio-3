using UnityEngine;
using System.Collections.Generic;

public class EnemyPool : MonoBehaviour
{
    public static EnemyPool Instance;

    private Dictionary<GameObject, ObjectPool> pools = new Dictionary<GameObject, ObjectPool>();

    private void Awake()
    {
        Instance = this;
    }

    public void CreatePool(GameObject prefab, int initialPoolSize)
    {
        if (!pools.ContainsKey(prefab))
        {
            GameObject poolObject = new GameObject(prefab.name + " Pool");
            poolObject.transform.SetParent(transform); // Organize pool under EnemyPool
            ObjectPool pool = poolObject.AddComponent<ObjectPool>();
            pool.prefab = prefab;
            pool.initialPoolSize = initialPoolSize;
            pools[prefab] = pool;
        }
    }

    public GameObject GetPooledObject(GameObject prefab)
    {
        if (pools.ContainsKey(prefab))
        {
            return pools[prefab].GetPooledObject();
        }
        else
        {
            CreatePool(prefab, 10); // Default initial pool size
            return pools[prefab].GetPooledObject();
        }
    }

    public int GetActiveCount(GameObject prefab)
    {
        if (pools.ContainsKey(prefab))
        {
            return pools[prefab].GetActiveCount();
        }
        return 0;
    }
}
