using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_inicial_script : MonoBehaviour
{
    camera_script cameraScript;


    public void Awake()
    {
        cameraScript = GameObject.Find("PLAYER").GetComponent<camera_script>();

    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            cameraScript.cameraInicialView = true;
        }
    }
    

}
