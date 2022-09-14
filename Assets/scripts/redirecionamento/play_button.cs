using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play_button : MonoBehaviour
{
    // Start is called before the first frame update
    public void Use()
    {
        SceneManager.LoadScene("dungeon");
    }

    
}
