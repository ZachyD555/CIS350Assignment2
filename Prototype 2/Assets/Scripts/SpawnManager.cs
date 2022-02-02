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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            // pick a random animal
            int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

            // pick a random spawn point
            Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

            // spawn the animal
            Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);

        }

    }
}