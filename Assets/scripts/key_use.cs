using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class key_use : MonoBehaviour
{
    // public GameObject effect;
    GameObject player;
    GameObject[] portas;
    public GameObject UiObject;



    public void Use()
    {


        portas = GameObject.FindGameObjectsWithTag("porta");
        player = GameObject.FindGameObjectWithTag("Player");
        

        var nearDistance = 1000000f;
        GameObject nearest = null;

        foreach (GameObject porta in portas)
        {
            float dist = Vector3.Distance(player.transform.position, porta.transform.position);
            if (dist < nearDistance)
            {
                nearest = porta;
                nearDistance = dist;
            }
        }

        if (nearest != null && nearDistance <= 2f)
        {
            Destroy(gameObject);
            Debug.Log("Usei!");
            Destroy(nearest);
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
