using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultBullet : MonoBehaviour
{
    [SerializeField] float xspeed, yspeed;
    protected Rigidbody2D rb;
    // Start is called before the first frame update

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }
    protected virtual void Start()
    {
        
        Vector2 myforce = new Vector2(xspeed, yspeed);
        rb.AddForce(myforce);
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }


}
