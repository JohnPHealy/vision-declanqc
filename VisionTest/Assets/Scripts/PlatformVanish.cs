using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

public class PlatformVanish : MonoBehaviour
{
    public Renderer r;

    void Start()
    {
        r = gameObject.GetComponent<Renderer>();  
        r.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            r.enabled = false;    
        }

    }

    private void OnTriggerExit(Collider other)
    {
        r.enabled = true;
    }
}


