﻿/*
 * Zach Daly
 * Assignment 3
 * Controls when game objects get destroyed upon leaving bounds
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attach to food and animals
public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    // Update is called once per frame
    void Update()
    {
        // if food goes out of bounds
        if (transform.position.z > topBound)
            Destroy(gameObject);

        // if animals go out of bounds
        if (transform.position.z < bottomBound)
        {
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();
            Destroy(gameObject);
        }
    }
}