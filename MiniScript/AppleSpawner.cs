using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject applePrefab;
    public float spawnRate = 1.5f;
    public float xRange = 7f;

    void Start()
    {
        InvokeRepeating("SpawnApple", 1f, spawnRate);
    }

    void SpawnApple()
    {
        float randomX = Random.Range(-xRange, xRange);
        Vector2 spawnPos = new Vector2(randomX, transform.position.y);

        Instantiate(applePrefab, spawnPos, Quaternion.identity);
    }
}
