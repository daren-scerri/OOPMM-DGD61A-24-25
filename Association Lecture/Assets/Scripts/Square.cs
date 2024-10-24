using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    Rigidbody2D squareRB;
    private float startPosX, startPosY, xspeed;

    ShapeMovement mySquareMovement;
    // Start is called before the first frame update
    void Start()
    {
        startPosX = this.gameObject.transform.position.x;
        startPosY = this.gameObject.transform.position.y;
        mySquareMovement = new ShapeMovement(startPosX, startPosY, xspeed, 0f);
        squareRB = GetComponent<Rigidbody2D>();
        mySquareMovement.ResetPosition(squareRB);
    }

    // Update is called once per frame
    void Update()
    {
        mySquareMovement.MoveLeft(squareRB);
        mySquareMovement.MoveRight(squareRB);
        mySquareMovement.ResetPosition(squareRB);

    }
}