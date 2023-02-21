using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float Bstrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BallMove ball = collision.gameObject.GetComponent<BallMove>();

        if (collision.gameObject.tag == "Ball")
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddMoreForce(-normal * this.Bstrength);
        }
    }
}
