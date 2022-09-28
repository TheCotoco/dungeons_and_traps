using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_script : MonoBehaviour
{
    public Camera cameraInicial;
    public Camera cameraCorredor;
    public Camera cameraSalaGrande;
    public Camera cameraTesouro1;
    public Camera cameraTesouro2;
    public bool cameraCorredorView = false; 
    public bool cameraSalaGrandeView = false;
    public bool cameraInicialView = true;
    public bool cameraTesouro1View= false;
    public bool cameraTesouro2View = false;


    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void Update()
    {
        if (cameraCorredorView){
            cameraInicial.enabled = false;
            cameraSalaGrande.enabled = false;
            cameraCorredor.enabled = true;
            cameraTesouro1.enabled = false;
            cameraTesouro2.enabled = false;
        }
        if (cameraInicialView)
        {
            cameraInicial.enabled = true;
            cameraSalaGrande.enabled = false;
            cameraCorredor.enabled = false;
            cameraTesouro1.enabled = false;
            cameraTesouro2.enabled = false;
        }
        if (cameraSalaGrandeView)
        {
            cameraInicial.enabled = false;
            cameraSalaGrande.enabled = true;
            cameraCorredor.enabled = false;
            cameraTesouro1.enabled = false;
            cameraTesouro2.enabled = false;
        }
        if (cameraTesouro1View)
        {
            cameraInicial.enabled = false;
            cameraSalaGrande.enabled = false;
            cameraCorredor.enabled = false;
            cameraTesouro1.enabled = true;
            cameraTesouro2.enabled = false;
        }
        if (cameraTesouro2View)
        {
            cameraInicial.enabled = false;
            cameraSalaGrande.enabled = false;
            cameraCorredor.enabled = false;
            cameraTesouro1.enabled = false;
            cameraTesouro2.enabled = true;
        }
    }
}
