using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    public static BGMusic bsmInstance;

    public AudioSource AS;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        if (bsmInstance == null)
        {
            bsmInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
