using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour

{
    
    public Transform player;
    public new Vector3 startPos;
    [SerializeField] private GameManager manager;

    private void Start()
    {
        startPos = new Vector3(2, 10, 10);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            manager.respawnPlayer();
        }
            
    }
}
