/*
 * (Noah Trillizio)
 * (Assignment 1)
 * (rasis score when player hits trigger)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach this to the player
public class PlayerEnterTriger : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
