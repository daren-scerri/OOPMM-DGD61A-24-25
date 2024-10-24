using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShapeData", menuName = "ScriptableObjects/ShapeData", order = 1)]
public class ShapeScriptableObject : ScriptableObject 

{ 
    public GameObject shapePrefab; 
    public float startXPos; 
    public float startYPos; 
    public float velocity; 
}