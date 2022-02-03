/*
 * Zach Daly
 * Assignment 3
 * Controls animal and food movement
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attach to animals and food
public class MoveForward : MonoBehaviour
{
    public float speed = 40;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
