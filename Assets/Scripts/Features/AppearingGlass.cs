using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearingGlass : MonoBehaviour
{
    private MeshRenderer MR;

    public BoxCollider BC;
    // Start is called before the first frame update
    void Start()
    {
        MR = GetComponent<MeshRenderer>();
        MR.enabled = false;
        BC.isTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Ball"))
        {
            MR.enabled = true;
            BC.isTrigger = false;

        }
    }
}
