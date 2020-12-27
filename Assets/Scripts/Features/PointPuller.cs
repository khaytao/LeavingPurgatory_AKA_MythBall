using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPuller : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] GameObject ball;
    private bool _inField = false;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = ball.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_inField)
        {
            Vector3 v = transform.position - ball.transform.position;
            _rb.AddForce(force * Time.smoothDeltaTime * v.normalized );
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            _inField = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            _inField = false;
        }
    }
}
