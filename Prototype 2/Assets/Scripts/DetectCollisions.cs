/*
 * Zach Daly
 * Assignment 2
 * Controls Collision Detection
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attach to food projectile
public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
