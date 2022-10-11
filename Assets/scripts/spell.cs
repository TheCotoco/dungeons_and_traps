using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell : MonoBehaviour
{

    public float life = 0.5f;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Awake()
    {
        Destroy(gameObject, life);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject collider = GameObject.Find("collider");
        Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(collider.GetComponent<Collider>(), GetComponent<Collider>());
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "obstaculos")
        {

            gameManager.play_barrel_sound();
            Destroy(other.gameObject);
           
        }

        if (other.gameObject.tag =="pote")
        {
            gameManager.play_pot_sound();
            Destroy(other.gameObject);
        }

        if (other.gameObject.name == "inimigo")
        {
            gameManager.play_enemy_dmg_sound();
            Destroy(other.gameObject);
        }

        Destroy(gameObject);


    }

   
}
