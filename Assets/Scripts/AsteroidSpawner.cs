using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

// simple behaviour, spawn asteroids while i active
public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private GameObject AsteroidPrefab;

    private BoxCollider _spawnVolume;

    void Start()
    {
        _spawnVolume = GetComponent<BoxCollider>();
        StartCoroutine(SpawnAsteroidCoroutine());
    }

    private void SpawnAsteroid()
    {
        Bounds bounds = _spawnVolume.bounds;

        // Create a random position within the bounds of the BoxCollider
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        float z = Random.Range(bounds.min.z, bounds.max.z);

        var asteroid = Instantiate(AsteroidPrefab, new Vector3(x, y, z), Quaternion.identity);
    }

    private IEnumerator SpawnAsteroidCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);

            SpawnAsteroid();
        }
    }
}
