using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    Rigidbody2D circleRB;
    
    private float startPosX, startPosY, yspeed;

    ShapeMovement myCircleMovement;
    // Start is called before the first frame update
    void Start()
    {
        startPosX = this.gameObject.transform.position.x;
        startPosY = this.gameObject.transform.position.y;
        myCircleMovement = new ShapeMovement(startPosX, startPosY, 0f, yspeed);
        circleRB = GetComponent<Rigidbody2D>();
        myCircleMovement.ResetPosition(circleRB);

    }

    // Update is called once per frame
    void Update()
    {
        
        myCircleMovement.MoveUp(circleRB);
        myCircleMovement.MoveDown(circleRB);
        myCircleMovement.ResetPosition(circleRB);
    }
}
