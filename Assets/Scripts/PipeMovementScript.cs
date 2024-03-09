using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    [SerializeField] private float speed = 5; 

    private void Update()
    {   
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
