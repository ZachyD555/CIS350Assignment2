﻿/* 
 * Zach Daly
 * Assignment 3
 * Displays the current score the player has
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Attach to Text UI object
public class DisplayScoreX : MonoBehaviour
{
    public Text textbox;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        // set up the reference to the Text component on this GameObject
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;
    }
}