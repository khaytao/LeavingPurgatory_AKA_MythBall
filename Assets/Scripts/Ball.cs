using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float maxVelocity;
    [SerializeField] private float maxAngularVelocity;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = maxAngularVelocity;

    }

    private void FixedUpdate()
    {

        rb.velocity = Mathf.Min(rb.velocity.magnitude, maxVelocity) * rb.velocity.normalized;

    }
}