using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    [SerializeField] private Collider realHole; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Collider ball = other.gameObject.GetComponent<Collider>();
            Physics.IgnoreCollision(realHole, ball, true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {

            Collider ball = other.gameObject.GetComponent<Collider>();
            Physics.IgnoreCollision(realHole, ball, false);
        }
    }
}
