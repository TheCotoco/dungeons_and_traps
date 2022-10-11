using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player_stats : MonoBehaviour 
{
    public float max_health = 10f;
    public float current_health = 10f;
    public float perception = 10f;
    public bool found_chest_1 = false;
    public bool found_chest_2 = false;
    public Image health_bar;

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "armadilha")
        {
            Debug.Log("colidiu com armadilha");
            current_health--;  
        }        
      
    }
    public void Update()
    {
        health_bar.fillAmount = current_health / max_health;  
        if(current_health <= 0)
        {
            SceneManager.LoadScene("game_over");
        }

       if (found_chest_1 && found_chest_2)
        {
            SceneManager.LoadScene("completed");
        }
    }
  
}
