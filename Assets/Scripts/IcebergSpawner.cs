using UnityEngine;

public class IcebergSpawner : MonoBehaviour
{
    public GameObject icebergPrefab;
    public float spawnInterval = 2f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnIceberg();
            timer = 0;
        }
    }

    void SpawnIceberg()
    {
        // Adjust the position as needed to line up with your game's design
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(icebergPrefab, spawnPosition, Quaternion.identity);
    }
}

