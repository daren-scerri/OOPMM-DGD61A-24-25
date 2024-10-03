using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject myCirclePrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myCirclePrefab, new Vector3(0f,0f,0f),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
