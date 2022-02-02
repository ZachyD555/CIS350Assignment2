using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attach to spawn manager
public class SpawnManager : MonoBehaviour
{
    // set this array of references in the inspector
    public GameObject[] prefabsToSpawn;

    // for spawnpoint
    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    void Start()
    {
        //InvokeRepeating("SpawnRandPrefab",2, 1.5f);

        // COROUTINE
        StartCoroutine(SpawnRandFabCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //SpawnRandPrefab();

        }
    }

    IEnumerator SpawnRandFabCoroutine()
    {
        // add a three second delay before first animal
        yield return new WaitForSeconds(3f);

        while (true)
        {
            SpawnRandPrefab();

            float randDelay = Random.Range(1.0f, 3.0f);

            yield return new WaitForSeconds(randDelay);
        }
    }

    void SpawnRandPrefab()
    {
        // pick a random animal
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        // pick a random spawn point
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        // spawn the animal
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}