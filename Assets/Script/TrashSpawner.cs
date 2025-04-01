using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public GameObject[] trashPrefabs;
    public float spawnRate = 10f;
    public float spawnXRange = 8f;

    void Start()
    {
        InvokeRepeating("SpawnTrash", 1f, spawnRate);
    }

    void SpawnTrash()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnXRange, spawnXRange), transform.position.y, 0);
        int randomIndex = Random.Range(0, trashPrefabs.Length);
        Instantiate(trashPrefabs[randomIndex], spawnPos, Quaternion.identity);
    }
}
