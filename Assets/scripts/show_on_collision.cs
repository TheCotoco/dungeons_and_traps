using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_on_collision : MonoBehaviour
{
    public GameObject targetObject;
    void Start()
    {
       targetObject.SetActive(false);       
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            targetObject.SetActive(true);
            Debug.Log("colidiu com player");            
            Debug.Log(targetObject);            
        }
       
    }
}
