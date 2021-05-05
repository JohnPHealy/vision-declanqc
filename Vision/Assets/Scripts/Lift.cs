using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == player.name)
        {
            print("contact");
            player.gameObject.GetComponent<CharacterController>().transform.parent = gameObject.transform;
        }
    }
    
}
