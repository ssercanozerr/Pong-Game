using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isPlayer1;
    public Rigidbody2D rgb;
    public float speed;

    void Update()
    {
        if (isPlayer1)
        {
            rgb.velocity = Vector2.up * Input.GetAxisRaw("VerticalPlayer1") * speed;
        }
        else 
        {
            rgb.velocity = Vector2.up * Input.GetAxisRaw("VerticalPlayer2") * speed;
        }

    }
}
