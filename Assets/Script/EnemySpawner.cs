using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;           
    public float spawnInterval = 2f;       
    public float minY = -4f, maxY = 4f;     
    public float spawnX = 10f;              

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        if (enemyPrefab != null)
        {
            float y = Random.Range(minY, maxY);
            Vector2 spawnPos = new Vector2(spawnX, y);
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }
    }
}
