using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameLogicScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score = 0;

    [ContextMenu("Add SCORE")]
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = $"{score}";
    }
    
}
