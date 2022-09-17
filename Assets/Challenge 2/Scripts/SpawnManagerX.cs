using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 0.5f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        SpawnRandomBall();
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int balls = Random.Range(0, 2);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[balls], spawnPos, ballPrefabs[balls].transform.rotation);
        // Spawn are random delay intervals
        Invoke("SpawnRandomBall", Random.Range(startDelay, spawnInterval));
    }   

}