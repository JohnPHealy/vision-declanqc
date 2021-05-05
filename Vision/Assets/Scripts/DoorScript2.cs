
using UnityEngine;
using System.Collections;
using System.Security.Cryptography;

public class DoorScript2 : MonoBehaviour
{

    public static bool doorKey;
    public bool open;
    public bool close;
    public bool inTrigger;
    public GameObject wall1;
    public GameObject wall2;

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
            if (close)
            {
                if (doorKey)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        open = true;
                        close = false;
                    }
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    close = true;
                    open = false;
                }
            }
        }

        if (open)
        {
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f),
                Time.deltaTime * 200);
            transform.rotation = newRot;
            Destroy(wall1);
            Destroy(wall2);
        }
        else
        {
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f),
                Time.deltaTime * 200);
            transform.rotation = newRot;
        }
    }
    void OnGUI()
    {
        if (inTrigger)
        {
            if (open)
            {
                GUI.skin.box.fontSize = 30;
                GUI.Box(new Rect(0, 0, 400, 50), "Press E to close");
            }
            else
            {
                if (doorKey)
                {
                    GUI.skin.box.fontSize = 30;
                    GUI.Box(new Rect(0, 0, 400, 50), "Press E to open");
                }
                else
                {
                    GUI.skin.box.fontSize = 30;
                    GUI.Box(new Rect(0, 0, 400, 50), "Need a key!");
                }
            }
        }
    }
}