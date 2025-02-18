﻿/*
 * (Noah Trillizio)
 * (Assignment 1)
 * (Keeps track of scores)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool won = false;
    public static int score = 0;

    public Text textbox;

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    void Update()
    {

        //If the game is not over, display score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        //win condition: 5 or more points
        if (score >= 5)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You win!\nPress R to Try Again!";
            }
            else
            {
                textbox.text = "You lose!\nPress R to Try Again!";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
