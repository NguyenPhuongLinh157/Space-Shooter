using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float spawnTime = 2f;
    public float spawnXRange = 7f;
    public float spawnY = 6f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnTime);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-spawnXRange, spawnXRange);

        Vector3 pos = new Vector3(randomX, spawnY, 0);

        Instantiate(enemyPrefab, pos, Quaternion.identity);
    }
}
