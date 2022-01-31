/*
 * (Noah Trillizio)
 * (Assignment 1)
 * (Keeps track of scores)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
