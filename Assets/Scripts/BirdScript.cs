using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D birdRigidbody;
    [SerializeField] private float flapStrenght = 10;

    private void Update()
    {
        Flap();
    }
    private void Flap()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            birdRigidbody.velocity = Vector2.up * flapStrenght;
        }
    }
}
