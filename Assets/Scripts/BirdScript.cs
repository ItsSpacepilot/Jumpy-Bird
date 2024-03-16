using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D birdRigidbody;
    [SerializeField] private float flapStrenght = 10;
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
            birdRigidbody.velocity = Vector2.up * flapStrenght;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        logic.GameOver();
    }
}
