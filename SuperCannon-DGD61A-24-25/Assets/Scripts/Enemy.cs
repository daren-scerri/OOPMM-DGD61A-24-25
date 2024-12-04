using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int strength;
    public int hitpoints;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            hitpoints -= 1;

        }

        if (hitpoints <= 0)
        {
            GameData.Score += 1;
            Debug.Log("Score: " + GameData.Score.ToString());
            Destroy(this.gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        GameData.PlayerHealth -= 1;
        Debug.Log("Player health: " + GameData.PlayerHealth.ToString());
        Destroy(this.gameObject);
        
    }

}
