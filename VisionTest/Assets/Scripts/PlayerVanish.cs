using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

public class PlayerVanish : MonoBehaviour
{
    public Renderer r;
    public GameObject Eye1;
    public GameObject Eye2;

    void Start()
    {
        r = gameObject.GetComponent<Renderer>();  
        r.enabled = true;
        Eye1.SetActive(true);
        Eye2.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            r.enabled = false;    
            Eye1.SetActive(false);
            Eye2.SetActive(false);
            
        }


    }

    private void OnTriggerExit(Collider other)
    {
        r.enabled = true;
        Eye1.SetActive(true);
        Eye2.SetActive(true);
    }
}
