/*
 * (Noah Trillizio)
 * (Assignment 1)
 * (tells the player when the've lost)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach this script to the player
public class LossOnFall : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
