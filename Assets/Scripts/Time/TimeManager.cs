using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public float countdownTime = 60; // time in seconds
    public TMP_Text timeText; //to show the remaining time
    public TMP_Text finalScoreText; //to show the final score
    public GameObject restartPanel;
    public bool isTimeRunning=true;
    public ScoreController scoreController;
    public GameObject successPanel;

    private void Start()
    {
        scoreController.isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimeRunning)
        {
            // subtract the time that has passed since the last frame from the countdown time
            countdownTime -= Time.deltaTime;

            // update the UI text with the remaining time
            timeText.SetText("Remaining Time: " + Mathf.FloorToInt(countdownTime));
          
        }
        

        // if the countdown has finished, do something
        if (countdownTime <= 0)
        {
            restartPanel.SetActive(true);
            finalScoreText.SetText("Your Score :" + scoreController.score);
            isTimeRunning = false;
            scoreController.isGameOver = true;
            timeText.SetText("Remaining Time: 0");
            
        }

        if (scoreController.enemyCount == 0)
        {
            successPanel.SetActive(true);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene("SpaceInvaders");
        scoreController.isGameOver = false;
    }

    
}
