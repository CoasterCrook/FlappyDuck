using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] float jumpVolume = 10f;

    Rigidbody2D birdRigidBody2D;

    void Start() 
    {
        birdRigidBody2D = GetComponent<Rigidbody2D>();
    }
    
    void OnJump(InputValue value)
    {
        birdRigidBody2D.velocity = Vector2.up * jumpVolume;
    }
}
