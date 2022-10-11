using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_laugh : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void Awake()
    {
       
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameManager.play_enemy_sound();
            Destroy(gameObject);
        }
    }
}
