using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] Material material;
    [SerializeField] float speed = 1f;

    void Update()
    {
       material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
