using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.UIElements;

public class UpgradeTrigger : MonoBehaviour
{
   public GameObject pickupEffect;
   public GameObject jumpText;
private void Start()
   {
      jumpText.SetActive(false);
   }

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Player"))
      {
         Pickup(other);
         jumpText.SetActive(true);
      
      }
   }

   void Pickup(Collider player)
   {
      //Instantiate(pickupEffect, transform.position, transform.rotation);

      ThirdPersonMovement_Updated DoubleJump = player.GetComponent<ThirdPersonMovement_Updated>();
      DoubleJump.UnlockedDoubleJump = true;
      Destroy(gameObject);
   }
   
}
