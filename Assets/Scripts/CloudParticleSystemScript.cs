using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudParticleSystemScript : MonoBehaviour
{
    [SerializeField] private ParticleSystem cloudParticleSystem;
    private GameLogicScript logic;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogicScript>();
        cloudParticleSystem = GetComponent<ParticleSystem>();
    }
    private void Update()
    {
        // if (!logic.isGameOnGoing)
        // {
        //     cloudParticleSystem.Pause();
        // }
    }
}
