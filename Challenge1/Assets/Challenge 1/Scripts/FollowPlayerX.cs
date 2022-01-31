/*
 * (Noah Trillizio)
 * (Assignment 1)
 * (makes the camera follow the player)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(40, 0, 0);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
