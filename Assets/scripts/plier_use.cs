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
   public GameManager gameManager;

        public void Awake()
    {        
        UiObject.SetActive(false);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void Use()
    {
        
        armadilhas = GameObject.FindGameObjectsWithTag("armadilha");
        player = GameObject.FindGameObjectWithTag("Player");
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
            gameManager.play_trap_disarm_sound();
            Destroy(nearest);
            return;
        }
    
        UiObject.SetActive(true);
        gameManager.cant_use_iten();
        StartCoroutine(waitForIt());
        
        return;
    }

    IEnumerator waitForIt()
    {        
        yield return new WaitForSeconds(1);
        UiObject.SetActive(false);
    }

}
