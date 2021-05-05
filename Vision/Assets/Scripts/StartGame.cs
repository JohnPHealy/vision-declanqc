using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject SceneChange;
    
void Update()
{
    {
        if (SceneChange.activeSelf == true)
        {
            SceneManager.LoadScene("Vision");
        }
      
    }
}
    }

