using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potion_use : MonoBehaviour
{
    player_stats ps;



    public GameManager gameManager; 
    public void Awake()
    {
        ps = GameObject.FindGameObjectWithTag("Player_collider").GetComponent<player_stats>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();     
    }

    public void Use()
    {
        gameManager.play_health_sound();
        ps.current_health = ps.current_health + 20;

        if(ps.current_health > ps.max_health)
        {
            ps.current_health = ps.max_health;
        }       
        Destroy(gameObject);       
    }

}