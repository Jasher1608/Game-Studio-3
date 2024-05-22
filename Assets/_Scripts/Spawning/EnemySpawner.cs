using UnityEngine;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    [System.Serializable]
    public class EnemyWave
    {
        public List<EnemyType> enemyTypes;
    }

    [System.Serializable]
    public class EnemyType
    {
        public GameObject enemyPrefab;
        public int minAmount;
        public float spawnInterval;
    }

    public List<EnemyWave> waves;
    public float waveInterval = 60f;

    private float waveTimer;
    private int currentWaveIndex = 0;
    private int totalEnemiesAlive = 0;
    private const int maxEnemiesAlive = 300;
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
        waveTimer = waveInterval;
        InvokeRepeating(nameof(SpawnEnemies), 0f, 1f);

        foreach (var wave in waves)
        {
            foreach (var enemyType in wave.enemyTypes)
            {
                EnemyPool.Instance.CreatePool(enemyType.enemyPrefab, 10); // Default initial pool size
            }
        }
    }

    private void Update()
    {
        waveTimer -= Time.deltaTime;

        if (waveTimer <= 0f)
        {
            waveTimer = waveInterval;
            currentWaveIndex++;
            if (currentWaveIndex >= waves.Count)
            {
                currentWaveIndex = 0; // Loop back to the first wave
            }
        }
    }

    private void SpawnEnemies()
    {
        if (totalEnemiesAlive >= maxEnemiesAlive) return;

        var currentWave = waves[currentWaveIndex];

        foreach (var enemyType in currentWave.enemyTypes)
        {
            if (GetEnemiesOfTypeAlive(enemyType.enemyPrefab) < enemyType.minAmount)
            {
                int enemiesToSpawn = enemyType.minAmount - GetEnemiesOfTypeAlive(enemyType.enemyPrefab);
                for (int i = 0; i < enemiesToSpawn; i++)
                {
                    SpawnEnemy(enemyType.enemyPrefab);
                }
            }
            else
            {
                if (Random.value < enemyType.spawnInterval)
                {
                    SpawnEnemy(enemyType.enemyPrefab);
                }
            }
        }
    }

    private void SpawnEnemy(GameObject enemyPrefab)
    {
        GameObject enemy = EnemyPool.Instance.GetPooledObject(enemyPrefab);
        if (enemy != null)
        {
            enemy.SetActive(true);
            enemy.transform.position = GetRandomSpawnPosition();
            totalEnemiesAlive++;
        }
    }

    private int GetEnemiesOfTypeAlive(GameObject enemyPrefab)
    {
        return EnemyPool.Instance.GetActiveCount(enemyPrefab);
    }

    private Vector3 GetRandomSpawnPosition()
    {
        Vector3 spawnPosition = Vector3.zero;

        float screenHeight = 2f * mainCamera.orthographicSize;
        float screenWidth = screenHeight * mainCamera.aspect;

        float spawnBuffer = 2f; // Distance outside the screen

        float xPosition = 0f;
        float yPosition = 0f;

        int side = Random.Range(0, 4); // 0 = Top, 1 = Bottom, 2 = Left, 3 = Right

        switch (side)
        {
            case 0: // Top
                xPosition = Random.Range(-screenWidth / 2, screenWidth / 2);
                yPosition = screenHeight / 2 + spawnBuffer;
                break;
            case 1: // Bottom
                xPosition = Random.Range(-screenWidth / 2, screenWidth / 2);
                yPosition = -screenHeight / 2 - spawnBuffer;
                break;
            case 2: // Left
                xPosition = -screenWidth / 2 - spawnBuffer;
                yPosition = Random.Range(-screenHeight / 2, screenHeight / 2);
                break;
            case 3: // Right
                xPosition = screenWidth / 2 + spawnBuffer;
                yPosition = Random.Range(-screenHeight / 2, screenHeight / 2);
                break;
        }

        spawnPosition = new Vector3(xPosition, yPosition, 0f);
        return spawnPosition;
    }

    public void OnEnemyDeath(GameObject enemy)
    {
        totalEnemiesAlive--;
    }
}
