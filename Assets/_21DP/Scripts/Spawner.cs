using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject item;
    public float spawnTime = 3f;

    private void Start()
    {
        InvokeRepeating("SpawnItem", 1f, spawnTime);
    }

    void SpawnItem()
    {
        if (Enemy_Manager._availableEnemies > 0)
        {

            Instantiate(item, transform.position, Quaternion.identity);
            Enemy_Manager._availableEnemies--;
        }
    }
}