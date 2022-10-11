using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource destroy_barrel;
    public AudioSource destroy_pot;
    public AudioSource damage;
    public AudioSource pickup;
    public AudioSource key;
    public AudioSource health_up;
    public AudioSource disarm_trap;
    public AudioSource door_opening;
    public AudioSource open_chest;
    public AudioSource enemy_laugh;
    public AudioSource enemy_dmg;
    public AudioSource spike;
    public AudioSource ball_falling;
    public AudioSource cant_use;

    public void play_chest_sound()
    {
        open_chest.Play();
    }
    public void play_enemy_dmg_sound()
    {
        enemy_dmg.Play();
    }
    public void play_enemy_sound()
    {
        enemy_laugh.Play();
    }
    public void spike_ball()
    {
        ball_falling.Play();
    }
    public void open_door()
    {
        door_opening.Play();
    }
    public void cant_use_iten()
    {
        cant_use.Play();
    }
    public void play_barrel_sound()
    {
        destroy_barrel.Play();
    }
    public void play_pot_sound()
    {
        destroy_pot.Play();
    }

    public void play_dmg_sound()
    {
        damage.Play();
    }

    public void play_iten_sound()
    {
        pickup.Play();
    }

    public void play_key_sound()
    {
        key.Play();
    }

    public void play_health_sound()
    {
        health_up.Play();
    }
    public void play_spike_sound()
    {
        spike.Play();
    }
    
    public void play_trap_disarm_sound()
    {
        disarm_trap.Play();
    }
}

