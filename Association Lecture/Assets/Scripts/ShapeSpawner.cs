using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour

{
    public ShapeScriptableObject circleObject;
    public ShapeScriptableObject squareObject;
    GameObject my_circle, my_square;
  //  public Vector3 circleSpawnPosition = new Vector3(-2, 0, 0);
  //  public Vector3 squareSpawnPosition = new Vector3(2, 0, 0);

    // This function runs when the game starts
    void Start()
    {
        SpawnShapes();
    }

    // Method to spawn the shapes
    void SpawnShapes()
    {
        if (circleObject != null)
        {
           my_circle = Instantiate(circleObject.shapePrefab, new Vector3(circleObject.startXPos, circleObject.startYPos, 0f) , Quaternion.identity);
           my_circle.GetComponent<Circle>().yspeed = circleObject.velocity; 
        }

        if (squareObject != null)
        {
           my_square =Instantiate(squareObject.shapePrefab, new Vector3(squareObject.startXPos, squareObject.startYPos, 0f), Quaternion.identity);
           my_square.GetComponent<Square>().xspeed = squareObject.velocity;
        }
    }
}