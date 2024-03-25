using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float spawnRate = 4;
    [SerializeField] private float hightOffset = 10;
    private float timer = 0;
    private GameLogicScript logic;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogicScript>();
        SpawnPipe();
    }
    private void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }
    private void SpawnPipe()
    {
        if (!logic.isGameOver)
        {
            float highestPoint = transform.position.y + hightOffset;
            float lowestPoint = transform.position.y - hightOffset;

            Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);


            Instantiate(pipePrefab, spawnPosition, transform.rotation);
        }
    }
}
