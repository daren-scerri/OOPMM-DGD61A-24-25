using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    Rigidbody2D squareRB;
    [SerializeField] float xspeed = 1;
    [SerializeField] float starting_Xpos = 0;
    [SerializeField] float starting_Ypos = 0;

    ShapeMovement mySquareMovement;
    // Start is called before the first frame update
    void Start()
    {
        mySquareMovement = new ShapeMovement(starting_Xpos, starting_Ypos, xspeed, 0f);
        squareRB = GetComponent<Rigidbody2D>();
        mySquareMovement.ResetPosition(squareRB);
    }

    // Update is called once per frame
    void Update()
    {
        mySquareMovement.MoveLeft(squareRB);
        mySquareMovement.MoveRight(squareRB);


    }
}