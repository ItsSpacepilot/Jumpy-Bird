using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D birdRigidbody;
    [SerializeField] private float flapStrenght = 10;
    [SerializeField] private float deadZone = 10; // this value is highest y position that bird can go.
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
        if (transform.position.y >= deadZone || transform.position.y <= -deadZone)
        {
            Death();
        }
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
        logic.GameOver();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundEffectManagerScript.intance.PlaySoundEffect(deathSoundEffect, transform, 1f);
        Death();
    }
}
