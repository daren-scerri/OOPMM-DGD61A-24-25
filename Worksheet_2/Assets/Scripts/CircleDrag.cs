using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDrag : MonoBehaviour
{
    Vector3 mousePos;
    public bool draggable = false;
    bool dragging = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dragging == true && draggable==true)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - new Vector3(0f, 0f, Camera.main.transform.position.z);
            this.gameObject.transform.position = mousePos;
        }
    }

    private void OnMouseDown()
    {
        dragging = true;
    }

    private void OnMouseUp()
    {
        dragging = false;
    }
}
