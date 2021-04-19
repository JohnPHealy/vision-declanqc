using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour

{
    
    public Transform player;
    public new Vector3 startpos;
    [SerializeField] private GameManager manager;

    private void Start()
    {
        startpos = new Vector3(2, 10, 10);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            manager.respawnPlayer();
        }
            
    }
}
