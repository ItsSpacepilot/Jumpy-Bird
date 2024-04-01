using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogicScript : MonoBehaviour
{
    public bool isGameOnGoing = true;
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score = 0;

    [ContextMenu("Add SCORE")]
    public void AddScore(int scoreToAdd, AudioClip scoreAudioclip)
    {
        if (isGameOnGoing)
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
}
