using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Collectors : MonoBehaviour
{
    [SerializeField] private AudioSource _source;


    private void Update()
    {
        transform.Rotate(new Vector3(0,0,100f)*Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            _source.Play();
            GameController.Instance.Collected();
            Destroy(gameObject);
        }

    }
}
