using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCircleSpawner : MonoBehaviour
{
    public GameObject mycirclePrefab;
    public bool draggable = false;
    Vector3 mousePos;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - new Vector3(0f,0f,Camera.main.transform.position.z);
        
        if (Input.GetMouseButtonDown(0) && count<5)
        {
            GameObject circle_instance = Instantiate(mycirclePrefab, mousePos, Quaternion.identity);
            circle_instance.GetComponent<CircleDrag>().draggable = draggable;
            count++;
        }
    }
}
