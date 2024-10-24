using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    Rigidbody2D circleRB;
    [SerializeField] float yspeed=1;
    [SerializeField] float starting_Xpos = 0;
    [SerializeField] float starting_Ypos = 0;

    ShapeMovement myCircleMovement;
    // Start is called before the first frame update
    void Start()
    {
        myCircleMovement = new ShapeMovement(starting_Xpos, starting_Ypos, 0f, yspeed);
        circleRB = GetComponent<Rigidbody2D>();
        myCircleMovement.ResetPosition(circleRB);

    }

    // Update is called once per frame
    void Update()
    {
        
        myCircleMovement.MoveUp(circleRB);
        myCircleMovement.MoveDown(circleRB);

    }
}
