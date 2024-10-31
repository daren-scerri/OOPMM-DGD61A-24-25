using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal_projectile : MonoBehaviour
{

    [SerializeField] float xspeed;

    public void FireProjectile(Rigidbody2D rb)
    {
        rb.gravityScale = 1.0f;
        Vector2 myforce = new Vector2(xspeed, 0);
        rb.AddForce(myforce);
    }
}
