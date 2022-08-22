using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    [SerializeField] float spawnRate = 1f;
    [SerializeField] float minHeight = -1f;
    [SerializeField] float maxHeight = 1f;

    void OnEnable() 
    {
        InvokeRepeating(nameof(SpawnPipes), spawnRate, spawnRate);
    }

    void SpawnPipes()
    {
        GameObject pipes = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight,maxHeight);
    }

    
}
