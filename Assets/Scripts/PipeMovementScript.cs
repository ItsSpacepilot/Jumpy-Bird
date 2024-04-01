using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float deadZone = -15;
    private void Update()
    {
        MovePipe();
        DestroyPipe();
    }
    private void MovePipe()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    private void DestroyPipe()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
