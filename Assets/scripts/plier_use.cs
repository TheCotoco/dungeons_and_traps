using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plier_use : MonoBehaviour
{
   // public GameObject effect;
   GameObject player;
   public GameObject UiObject;
   GameObject[] armadilhas;
   GameObject itemToDestroy;

    public void Awake()
    {        
        UiObject.SetActive(false);
    }

    public void Use()
    {
        armadilhas = GameObject.FindGameObjectsWithTag("armadilha");
        player = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(armadilhas);

        var nearDistance = 1000000f;
        GameObject nearest = null;

        foreach(GameObject armadilha in armadilhas)
        {
            float dist = Vector3.Distance(player.transform.position, armadilha.transform.position);
            if (dist < nearDistance)
            {
                nearest = armadilha;
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
