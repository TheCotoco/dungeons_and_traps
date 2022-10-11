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
    public GameManager gameManager;
    public void Use()
    {      
        portas = GameObject.FindGameObjectsWithTag("porta");
        player = GameObject.FindGameObjectWithTag("Player");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();


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
            gameManager.open_door();
            Destroy(nearest);
            return;
        }

        Debug.Log("Não posso usar aqui");
        UiObject.SetActive(true);
        gameManager.cant_use_iten();
        StartCoroutine(waitForIt());
        


    }

    IEnumerator waitForIt()
    {
        yield return new WaitForSeconds(1);
        UiObject.SetActive(false);
    }
    
}
