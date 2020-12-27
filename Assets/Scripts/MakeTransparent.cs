using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MakeTransparent : MonoBehaviour
{
    [SerializeField] private Renderer renderer;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Transform ballTransform;
    [SerializeField] private int layerNum;


    void Update()
    {
        
        var ray = new Ray(cameraTransform.position, ballTransform.position - cameraTransform.position);
        RaycastHit hit;
        LayerMask mask = 1 << layerNum;
        if (Physics.Raycast(ray, out hit,Vector3.Distance(cameraTransform.position, ballTransform.position), mask))
        {
            GameObject go = hit.transform.gameObject;
           
            if (go.name == "BoxRoom")
            {
                renderer.shadowCastingMode = ShadowCastingMode.ShadowsOnly;

            }
            else
            {
                renderer.shadowCastingMode = ShadowCastingMode.On;
            }

        }
        else
        {
            renderer.shadowCastingMode = ShadowCastingMode.On;

            
        }
  
     
    }
}
