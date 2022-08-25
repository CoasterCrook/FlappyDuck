using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] float jumpVolume = 10f;
    [SerializeField] AudioSource wingsAudio;
    [SerializeField] AudioSource deathAudio;
    [SerializeField] AudioSource scoreAudio;

    Rigidbody2D birdRigidBody2D;
    GameManager gameManager;
    
    void Awake() 
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Start() 
    {
        birdRigidBody2D = GetComponent<Rigidbody2D>();
    }
    
    void OnJump(InputValue value)
    {
        birdRigidBody2D.velocity = Vector2.up * jumpVolume;
        if (!gameManager.isPaused)
        {
        wingsAudio.Play();
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Score")
        {
            scoreAudio.Play();
            gameManager.IncreaseScore();
        }
        else if (other.tag == "Obstacle")
        {
            deathAudio.Play();
            gameManager.GameOver();
        }
    }
}
