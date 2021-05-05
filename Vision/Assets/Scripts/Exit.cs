using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject exit;

    // Update is called once per frame
    void Update()
    {
        {
            if (exit.activeSelf == true)
            {
                Application.Quit();
            }
      
        }
    }
}
