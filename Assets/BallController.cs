using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D rgb;
    public float speed;
    void Start()
    {
        float x = UnityEngine.Random.Range(0, 2)== 0 ? -1 : 1;
        float y = UnityEngine.Random.Range(0, 2)== 0 ? -1 : 1;
        rgb.velocity = new Vector2(x * speed, y * speed);
    }

    void Update()
    {
        
    }
}
