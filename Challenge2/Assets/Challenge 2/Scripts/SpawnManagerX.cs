/* 
 * Zach Daly
 * Assignment 3
 * Controls the random spawnign of balls
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    public HealthSystemX healthSystem;

    // Start is called before the first frame update
    void Start()
    {
        // ref to healthSystem
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystemX").GetComponent<HealthSystemX>();

        //COROUTINE
        StartCoroutine(SpawnRandBallCoroutine());
    }

    IEnumerator SpawnRandBallCoroutine()
    {
        while (!healthSystem.gameOver)
        {
            SpawnRandomBall();

            float randDelay = Random.Range(3.0f, 5.0f);

            yield return new WaitForSeconds(randDelay);
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Pick a random ball
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
}