using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    Rigidbody2D squareRB;
    [SerializeField] float xspeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        squareRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            squareRB.velocity = new Vector2(-xspeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            squareRB.velocity = new Vector2(xspeed, 0);
        }


    }
}