using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerMovement : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;
    [SerializeField] private float yHight;

    void Update()
    {
        Vector3 pos = ballTransform.position;
        transform.position = new Vector3(pos.x, yHight, pos.z);

    }
}
