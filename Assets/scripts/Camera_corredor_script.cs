using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_corredor_script : MonoBehaviour
{
    camera_script cameraScript;
    public void Awake()
    {
        cameraScript = GameObject.Find("PLAYER").GetComponent<camera_script>();

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cameraScript.cameraCorredorView = true;
            cameraScript.cameraInicialView = false;
            cameraScript.cameraSalaGrandeView= false;
            cameraScript.cameraTesouro1View = false;
            cameraScript.cameraTesouro2View = false;
        }
    }
}
