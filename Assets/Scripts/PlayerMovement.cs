using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isPlayer1;
    public bool isPlayer2;
    public bool isPlayer3;
    public bool isPlayer4;
    public float speed;
    public Rigidbody2D rb;
    public BallMove ball;

    private float movement;
    private float movement2;

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else if (isPlayer3)
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        if (isPlayer2)
        {
            movement2 = Input.GetAxisRaw("Horizontal");
        }
        else if (isPlayer4)
        {
            movement2 = Input.GetAxisRaw("Horizontal2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
        rb.velocity = new Vector2(movement2 * speed, rb.velocity.y);
    }
}