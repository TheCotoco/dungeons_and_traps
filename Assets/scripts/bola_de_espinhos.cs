using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola_de_espinhos : MonoBehaviour
{
    public GameObject targetObject;
    public GameManager gameManager;
    public bool hasPlayed = false;
    void Start()
    {
        targetObject.SetActive(false);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!hasPlayed)
            {
                gameManager.spike_ball();
                hasPlayed = true;
            }
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
