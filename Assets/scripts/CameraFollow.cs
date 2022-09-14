using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{
   public float maxAngle;
 
    public float sensitivityY;
    public float distance;
    public Transform camera;
    private Vector3 offset;
    public Transform target;

    Quaternion center;
 
    void Start(){
 
        this.center = camera.rotation;
        offset = (transform.position - target.position).normalized * distance;
        transform.position = target.position + offset;

    }
 
    void Update ()
    {
        if (Input.GetMouseButton(2))
        {
            float rotationYInput = Input.GetAxis("Mouse X") * sensitivityY * Time.deltaTime;
            Quaternion yQuaternion = Quaternion.AngleAxis(rotationYInput, -Vector3.up);
            Quaternion temp = this.camera.localRotation * yQuaternion;
                   
            if (Quaternion.Angle(center, temp) < this.maxAngle) camera.localRotation = temp;
        }
           
        
        transform.position = target.position + offset;
    }
 
}

