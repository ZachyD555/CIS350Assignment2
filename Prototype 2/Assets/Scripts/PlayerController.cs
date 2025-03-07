﻿/*
 * Zach Daly
 * Assignment 3
 * Controls player movement
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attach to player
public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 14;

    // Update is called once per frame
    void Update()
    {
        // getting input from left/right or A/D
        horizontalInput = Input.GetAxis("Horizontal");

        // horizontal transform
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Keep player in bounds
        if (transform.position.x < -xRange)
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        if (transform.position.x > xRange)
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }
}
