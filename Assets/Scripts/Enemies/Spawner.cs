using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;   // El que vols generar
    public float spawnRate = 2f; // Cada quants segons

    private float nextSpawnTime;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            Spawn();
            nextSpawnTime = Time.time + spawnRate;
        }
    }

    void Spawn()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}