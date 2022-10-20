using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bau2 : MonoBehaviour
{

    player_stats ps;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Awake()
    {
        ps = GameObject.FindGameObjectWithTag("Player_collider").GetComponent<player_stats>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player_collider")
        {
            ps.found_chest_2 = true;
            gameManager.play_chest_sound();
            Destroy(gameObject);
            Debug.Log(ps.found_chest_1);
            Debug.Log(ps.found_chest_2);

        }

    }
}
