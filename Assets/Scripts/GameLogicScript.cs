using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogicScript : MonoBehaviour
{
    public bool isGameOver = false;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameoverScreen;
    private int score = 0;

    [ContextMenu("Add SCORE")]
    public void AddScore(int scoreToAdd, AudioClip scoreAudioclip)
    {
        if (!isGameOver)
        {
            score += scoreToAdd;
            SoundEffectManagerScript.intance.PlaySoundEffect(scoreAudioclip, transform, 1f);
            scoreText.text = $"{score}";
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        gameoverScreen.SetActive(true);
        isGameOver = true;
    }
}
