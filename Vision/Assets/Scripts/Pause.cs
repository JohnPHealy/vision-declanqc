using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public AudioSource levelMusic;
    public GameObject play;
    
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Time.timeScale = 0;
                Debug.Log("pause");
                play.SetActive(true);
            }

            if (play.activeSelf == false)

            {
                Time.timeScale = 1;
            }

   
        }
    }
}