using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;
    
    private void Update()
    {
        
        if (Input.GetKeyDown("space"))
        {
            audioSource.PlayOneShot(clip, volume);  
        }
    }
}