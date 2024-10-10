using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject myCirclePrefab;
    public float padding;
    private float XMin, XMax, YMin, YMax;

    // Start is called before the first frame update
    void Start()
    {
        Camera mycamera = Camera.main;
        XMin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        YMin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        XMax = mycamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        YMax = mycamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
        Instantiate(myCirclePrefab, new Vector3(XMin+padding, YMin+padding, 0f), Quaternion.identity);
        Instantiate(myCirclePrefab, new Vector3(XMin+padding, YMax-padding, 0f), Quaternion.identity);
        Instantiate(myCirclePrefab, new Vector3(XMax-padding, YMin+padding, 0f), Quaternion.identity);
        Instantiate(myCirclePrefab, new Vector3(XMax-padding, YMax-padding, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
