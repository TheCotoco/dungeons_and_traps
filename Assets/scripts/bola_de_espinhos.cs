using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola_de_espinhos : MonoBehaviour
{
    public GameObject targetObject;
    void Start()
    {
        targetObject.SetActive(false);
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            targetObject.SetActive(true);
            Debug.Log("colidiu com player");
            Debug.Log(targetObject);
            StartCoroutine(waitForIt());

        }

    }

    IEnumerator waitForIt()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }
}
