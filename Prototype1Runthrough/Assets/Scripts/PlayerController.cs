/*
 * (Noah Trillizio)
 * (Assignment 1)
 * (controls the player)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    public float forwadInput;
    public float horizontalInput;


    // Update is called once per frame
    void Update()
    {
        forwadInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //Move Forward with forwwaed inpurt
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwadInput);

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
