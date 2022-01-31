/*
 * (Noah Trillizio)
 * (Assignment 1)
 * (Spins Propeller)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningPropeller : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
