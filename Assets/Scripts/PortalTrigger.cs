using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{
    [SerializeField] private Collider Destination;
    [SerializeField] private BreakableGlass BG;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        
        Vector3 pos = Destination.transform.up;
        rb.MovePosition(Destination.transform.position);
        rb.velocity = pos * rb.velocity.magnitude;
        if (BG != null)
        {
            BG.forceThreshold = 0; //workaround
        }
        
    }
}
