using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    public int enemyCount=27;
    public bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score : " + score;
    }

    public void updateScore(int increment)
    {
        if (!isGameOver)
        {
            score += increment;
            scoreText.text = "Score : " + score;
            enemyCount -= 1;
        }
    
    }
}
