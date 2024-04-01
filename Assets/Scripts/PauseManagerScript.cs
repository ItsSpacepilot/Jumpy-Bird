using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject gameroverScreen;
    [SerializeField] private GameObject pauseScreen;
    private bool isPaused = false;
    private bool isGameover = false;

    public static PauseManagerScript instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isGameover)
        {
            TogglePause();
        }
    }
    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f;
            pauseScreen.SetActive(isPaused);
        }
        else
        {
            Time.timeScale = 1f;
            pauseScreen.SetActive(isPaused);
        }
    }
    public void SetGameOver()
    {
        isGameover = true;
        Time.timeScale = 1f;
        gameroverScreen.SetActive(isGameover);
    }
}
