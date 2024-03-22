using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D birdRigidbody;
    [SerializeField] private float flapStrenght = 10;
    [SerializeField] private AudioClip flappSoundEffect;
    [SerializeField] private AudioClip deathSoundEffect;
    private GameLogicScript logic;
    private bool isAlive = true;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogicScript>();
    }
    private void Update()
    {
        Flap();
    }
    private void Flap()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            SoundEffectManagerScript.intance.PlaySoundEffect(flappSoundEffect, transform, 1f);
            birdRigidbody.velocity = Vector2.up * flapStrenght;
        }
    }
    private void Death()
    {
        isAlive = false;
        SoundEffectManagerScript.intance.PlaySoundEffect(deathSoundEffect, transform, 1f);
        logic.GameOver();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Death();
    }
}
