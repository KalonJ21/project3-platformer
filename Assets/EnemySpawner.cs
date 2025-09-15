using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;

    public float minSpawnTime = 1f; // random spawn time between 1 and 3 seconds
    public float maxSpawnTime = 4f;

    public float minY = -2f;  // Optional: control random height
    public float maxY = 2f;

    private float timer;
    private float nextSpawnTime;

    void Start()
    {
        SetNextSpawnTime();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= nextSpawnTime)
        {
            SpawnEnemy();
            SetNextSpawnTime();
        }
    }

    void SpawnEnemy()
    {
        // Randomize Y position if desired
        Vector3 spawnPos = spawnPoint.position;
        spawnPos.y = Random.Range(minY, maxY); // Optional: vary up/down

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }

    void SetNextSpawnTime()
    {
        timer = 0f;
        nextSpawnTime = Random.Range(minSpawnTime, maxSpawnTime); //randomizes spawn rate between 1 and 2 sec
    }
}





/*
//OG Code
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;      // Drag your enemy prefab here
    public float spawnInterval = 2f;    // Time between spawns
    public Transform spawnPoint;        // Where enemies appear

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }
}
*/