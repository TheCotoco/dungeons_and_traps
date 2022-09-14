using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class key_use : MonoBehaviour
{
    // public GameObject effect;
    GameObject player;
    GameObject porta;
    public GameObject UiObject;



    public void Use()
    {
        porta = GameObject.FindGameObjectWithTag("porta");
        player = GameObject.FindGameObjectWithTag("Player");


        float dist = Vector3.Distance(player.transform.position, porta.transform.position);

        if (dist < 1)
        {
            UiObject.SetActive(false); 
            Destroy(gameObject);
            Debug.Log("Usei!");
            Destroy(porta);
            StartCoroutine(waitForIt());
            SceneManager.LoadScene("completed");
            return;
        }

        Debug.Log("Não posso usar aqui");
        UiObject.SetActive(true);
        StartCoroutine(waitForIt());

    }

    IEnumerator waitForIt()
    {
        yield return new WaitForSeconds(1);
        UiObject.SetActive(false);
    }
   
}
