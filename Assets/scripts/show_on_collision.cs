using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_on_collision : MonoBehaviour
{
    public GameObject targetObject;
    public GameManager gameManager;

    public bool played_sound = false;
    void Start()
    {
       targetObject.SetActive(false);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Player_collider")
        {
            if(played_sound == false)
            {
                gameManager.play_spike_sound();
                played_sound = true;
            }            
            targetObject.SetActive(true);        
        }       
    }
}
