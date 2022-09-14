using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cast_spell : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject spell;
    public float speed = 10f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            var castSpell = Instantiate(spell, spawnPoint.position, spawnPoint.rotation);
            castSpell.GetComponent<Rigidbody>().velocity = spawnPoint.forward * speed;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            var castSpell = Instantiate(spell, spawnPoint.position, spawnPoint.rotation);
            castSpell.GetComponent<Rigidbody>().velocity = -spawnPoint.forward * speed;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            var castSpell = Instantiate(spell, spawnPoint.position, spawnPoint.rotation);
            castSpell.GetComponent<Rigidbody>().velocity = spawnPoint.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            var castSpell = Instantiate(spell, spawnPoint.position, spawnPoint.rotation);
            castSpell.GetComponent<Rigidbody>().velocity = -spawnPoint.right * speed;
        }

    }









}
