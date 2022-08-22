using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float leftEdge;
    
    void Start() 
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 2;    
    }
    
    void Update() 
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
