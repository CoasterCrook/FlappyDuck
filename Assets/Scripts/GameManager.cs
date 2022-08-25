using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI endScoreText;
    
    [Header("Objects")]
    [SerializeField] GameObject playButton;
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject startTextImage;
    
    float score;
    public bool isPaused;

    void Awake() 
    {
        StartMenu();
        gameOver.SetActive(false);
    }

    public void Play()
    { 
        endScoreText.text = "Score: 0";
        endScoreText.enabled = false;
        score = 0;
        scoreText.enabled = true;
        isPaused = false;
        playerMovement.transform.position = new Vector3((float)-1.5, 0, (float)-0.1);
        Time.timeScale = 1f;
        scoreText.text = score.ToString(); 
        playButton.SetActive(false);
        gameOver.SetActive(false);
        startTextImage.SetActive(false);
        
        PipeMover[] pipes = FindObjectsOfType<PipeMover>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    void StartMenu()
    {
        endScoreText.enabled = false;
        scoreText.enabled = false;
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        endScoreText.text = "Score: " + score.ToString(); 
    }

    public void GameOver()
    { 
        endScoreText.enabled = true;
        scoreText.enabled = false;
        isPaused = true;
        Time.timeScale = 0f;
        gameOver.SetActive(true);
        playButton.SetActive(true);
        startTextImage.SetActive(false);
    }
}
