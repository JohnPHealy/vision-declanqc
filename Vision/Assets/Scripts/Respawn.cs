using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class Respawn : MonoBehaviour


{
    
    public GameObject player;
    public Transform destination;
  

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == player.gameObject.name)
        {
            print("contact");
            player.transform.position = destination.position;
            
        }
    }
}
