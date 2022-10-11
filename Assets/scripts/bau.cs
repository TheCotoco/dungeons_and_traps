using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bau : MonoBehaviour
{
   
    player_stats ps;

    // Start is called before the first frame update
    void Awake()
    {

   
        ps = GameObject.FindGameObjectWithTag("Player_collider").GetComponent<player_stats>();

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player_collider")
        {
            ps.found_chest_1 = true;
            Destroy(gameObject);
            Debug.Log(ps.found_chest_1);
            Debug.Log(ps.found_chest_2);

        }

    }
}
