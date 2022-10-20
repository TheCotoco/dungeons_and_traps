using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;


public class cast_spell : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject spell;
    public float speed = 10f;
    private GameObject player;
    public AudioSource spell_sound;


    void Start()
    {
        player = GameObject.Find("mago_player");
        spell_sound = GetComponent<AudioSource>();
        
    }

    private void Update()
    {
       
            if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
            {
                spell_sound.Play();
                if (player.transform.eulerAngles.y >= 0.0f && player.transform.eulerAngles.y < 90f)
                {
                    var castSpell = Instantiate(spell, spawnPoint.position, spawnPoint.rotation);
                    castSpell.GetComponent<Rigidbody>().velocity = Vector3.right * speed;
                }
                if (player.transform.eulerAngles.y >= 90.0f && player.transform.eulerAngles.y < 180f)
                {
                    var castSpell = Instantiate(spell, spawnPoint.position, spawnPoint.rotation);
                    castSpell.GetComponent<Rigidbody>().velocity = Vector3.back * speed;
                }
                if (player.transform.eulerAngles.y >= 180.0f && player.transform.eulerAngles.y < 270f)
                {
                    var castSpell = Instantiate(spell, spawnPoint.position, spawnPoint.rotation);
                    castSpell.GetComponent<Rigidbody>().velocity = Vector3.left * speed;
                }
                if (player.transform.eulerAngles.y >= 270.0f && player.transform.eulerAngles.y < 360f)
                {
                    var castSpell = Instantiate(spell, spawnPoint.position, spawnPoint.rotation);
                    castSpell.GetComponent<Rigidbody>().velocity = Vector3.forward * speed;
                }
            }
   
   
    }
}