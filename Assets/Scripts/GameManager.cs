using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject playButton;
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] GameObject gameOver;
    
    float score;

    void Awake() 
    {
        Application.targetFrameRate = 60;
        Pause();
        gameOver.SetActive(false);
    }

    public void Play()
    {
        playerMovement.transform.position = new Vector3(0,0, (float)-0.1);
        Time.timeScale = 1f;
        score = 0;
        scoreText.text = score.ToString(); 
        playButton.SetActive(false);
        gameOver.SetActive(false);
        
        PipeMover[] pipes = FindObjectsOfType<PipeMover>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    void Pause()
    {
        Time.timeScale = 0f;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString(); 
    }

    public void GameOver()
    { 
        Time.timeScale = 0f;
        gameOver.SetActive(true);
        playButton.SetActive(true);
    }
}
