using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bau2 : MonoBehaviour
{

    player_stats ps;

    // Start is called before the first frame update
    void Awake()
    {

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        ps = GameObject.FindGameObjectWithTag("Player").GetComponent<player_stats>();

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ps.found_chest_2 = true;
            Destroy(gameObject);
            Debug.Log(ps.found_chest_1);
            Debug.Log(ps.found_chest_2);

        }

    }
}
