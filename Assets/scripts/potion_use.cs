using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potion_use : MonoBehaviour
{
    player_stats ps;
 

    public void Awake()
    {
        ps = GameObject.FindGameObjectWithTag("Player_collider").GetComponent<player_stats>();
             
    }

    public void Use()
    {
      
        ps.current_health = ps.current_health + 20;

        if(ps.current_health > ps.max_health)
        {
            ps.current_health = ps.max_health;
        }

        Destroy(gameObject);       
    }

}