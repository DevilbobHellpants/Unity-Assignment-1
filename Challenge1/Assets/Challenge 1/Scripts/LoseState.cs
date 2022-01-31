/*
 * (Noah Trillizio)
 * (Assignment 1)
 * (Asstablishes when player loses)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach this script to the player
public class LoseState : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -55 || transform.position.y > 110)
        {
            ScoreManager.gameOver = true;
        }
    }
}
