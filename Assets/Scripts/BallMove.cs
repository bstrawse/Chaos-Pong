using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{

    public GameManager gm;
    private Rigidbody2D rb;
    public float speed = 200.0f;
    public string lastHit = null;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void resetPosition()
    {
        rb.position = Vector2.zero;
        rb.velocity = Vector2.zero;
        sr.color = Color.white;

        AddStartingForce();
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        rb.AddForce(direction * this.speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1" || 
            collision.gameObject.tag == "Player2" || 
            collision.gameObject.tag == "Player3" || 
            collision.gameObject.tag == "Player4" )
        {
            lastHit = collision.gameObject.tag;
            sr.color = collision.gameObject.GetComponent<SpriteRenderer>().color;
        }

        if (lastHit != "Player1" && collision.gameObject.tag == "Goal1")
        {
            if (lastHit == "Player2")
            {
                gm.p2s();
            } 
            else if (lastHit == "Player3")
            {
                gm.p3s();
            }
            else if (lastHit == "Player4")
            {
                gm.p4s();
            }
            else
            {
                resetPosition();
            }
            lastHit = null;
        }
        else if (lastHit != "Player2" && collision.gameObject.tag == "Goal2")
        {
            if (lastHit == "Player1")
            {
                gm.p1s();
            }
            else if (lastHit == "Player3")
            {
                gm.p3s();
            }
            else if (lastHit == "Player4")
            {
                gm.p4s();
            }
            else
            {
                resetPosition();
            }
            lastHit = null;
        }
        else if (lastHit != "Player3" && collision.gameObject.tag == "Goal3")
        {
            if (lastHit == "Player2")
            {
                gm.p2s();
            }
            else if (lastHit == "Player1")
            {
                gm.p1s();
            }
            else if (lastHit == "Player4")
            {
                gm.p4s();
            }
            else
            {
                resetPosition();
            }
            lastHit = null;
        }
        else if (lastHit != "Player4" && collision.gameObject.tag == "Goal4")
        {
            if (lastHit == "Player2")
            {
                gm.p2s();
            }
            else if (lastHit == "Player3")
            {
                gm.p3s();
            }
            else if (lastHit == "Player1")
            {
                gm.p1s();
            }
            else
            {
                resetPosition();
            }
            lastHit = null;
        }
        else if (lastHit == null && (collision.gameObject.tag == "Goal1" ||
                                     collision.gameObject.tag == "Goal2" ||
                                     collision.gameObject.tag == "Goal3" ||
                                     collision.gameObject.tag == "Goal4"))
        {
            resetPosition();
        } 
        else if (lastHit != null && (collision.gameObject.tag == "Goal1" ||
                                     collision.gameObject.tag == "Goal2" ||
                                     collision.gameObject.tag == "Goal3" ||
                                     collision.gameObject.tag == "Goal4"))
        {
            resetPosition();
        }
    }

    public void AddMoreForce(Vector2 force)
    {
        rb.AddForce(force);
    }
}
