using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomAlternate : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    private bool _dragging = false;

    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        //rb.centerOfMass = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            _dragging = false;

        }   
    }

    private void OnMouseDrag()
    {
        _dragging = true;

    }

    private void FixedUpdate()
    {
        if (_dragging)
        {
            float x = Input.GetAxis("Mouse X") * rotationSpeed;
            float y = Input.GetAxis("Mouse Y") * rotationSpeed;

            if (Input.GetKey(KeyCode.LeftControl))
            {
                int sign = 1;
                var playerScreenPoint = Camera.main.WorldToScreenPoint(transform.position);
                if (Input.mousePosition.x < playerScreenPoint.x)
                {
                    sign = -1;
                    // Debug.Log("mouse is to the left");
                }
                else
                {
                    // Debug.Log("mouse is to the right");
                }
                rb.AddTorque(Vector3.down * (y * sign), ForceMode.Impulse);
            }

            else
            {
                rb.AddTorque(Vector3.forward * x, ForceMode.Impulse);
                rb.AddTorque(Vector3.right * y, ForceMode.Impulse);
            }
        }
    }
}

