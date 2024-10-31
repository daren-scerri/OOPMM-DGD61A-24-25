using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class BulletControl : MonoBehaviour 
{ 

    Rigidbody2D rb;
    FireUp gunfire;
    Horizontal_projectile myprojectile;

  
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        gunfire = GetComponent<FireUp>();
        if (gunfire != null) gunfire.Fire(rb);   // OPTION1 : checks if gunfire instance exists before using it

        myprojectile = GetComponent<Horizontal_projectile>();

        try          //OPTION2: checking if projectile exists using exception handling try..catch
        {
            myprojectile.FireProjectile(rb);
        }
        catch (NullReferenceException ex)
        {
            Debug.Log(this.gameObject.name + " has no projectile firing");
        }

    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
