using UnityEngine;
using System.Collections;
using System.Net.Mime;

public class DoorKey2 : MonoBehaviour
{

    public bool inTrigger;

    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DoorScript2.doorKey = true;
                Destroy(this.gameObject);
            }
        }
    }


    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.skin.box.fontSize = 30;
            GUI.Box(new Rect(0, 60, 400, 50),"Press E to take key");
            
        }
    }
}