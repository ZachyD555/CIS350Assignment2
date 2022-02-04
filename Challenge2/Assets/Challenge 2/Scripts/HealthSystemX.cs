using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthSystemX : MonoBehaviour
{
    public int health, maxHealth;

    public List<Image> hearts;
    public Sprite fullHeart, emptyHeart;

    public bool gameOver = false;

    public GameObject gameOverText;

    // Update is called once per frame
    void Update()
    {
        // set health if it is larger than max
        if (health > maxHealth)
            health = maxHealth;

        for (int i = 0; i < hearts.Count; i++)
        {
            // Diplay full or empty heart sprite based on current health
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            //Show the number of hearts equal to current max health
            if (i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if (health <= 0)
        {
            gameOver = true;
            gameOverText.SetActive(true);

            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    public void TakeDamage()
    {
        health--;
    }

    public void AddMaxHealth()
    {
        maxHealth++;
    }
}