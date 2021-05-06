using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    void Update()
    {
        if (menu.activeSelf == true)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
