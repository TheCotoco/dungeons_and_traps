using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go_to_main_menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Use()
    {
        SceneManager.LoadScene("titleScreem");
    }
}
