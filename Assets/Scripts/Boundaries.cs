using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("miri");
        Rigidbody ball = other.gameObject.GetComponent<Rigidbody>();
        var dir = ball.position - other.bounds.center;
        ball.AddForce(dir.normalized* (force+ball.velocity.magnitude), ForceMode.Impulse);
    }
}
