/*
 * (Noah Trillizio)
 * (Assignment 1)
 * (raises the score after a trigger is hit)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this to a trigger zone
public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && triggered == false)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }



}
