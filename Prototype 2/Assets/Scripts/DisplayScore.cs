/*
 * Zach Daly
 * Assignment 3
 * Displays score for player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// attach to a Text UI object
public class DisplayScore : MonoBehaviour
{
    public Text textbox;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        // set up the reference to the Text comonent on this GameObject
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;
    }
}
