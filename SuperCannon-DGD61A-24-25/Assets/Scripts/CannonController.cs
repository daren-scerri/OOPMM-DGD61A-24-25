using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CannonController : MonoBehaviour
{
    [SerializeField] GameObject bullet1Prefab;
    [SerializeField] GameObject bullet2Prefab;
    [SerializeField] Transform cannonTip;
    Quaternion clampRotationLow, clampRotationHigh;
    
    // Start is called before the first frame update
    void Start()
    {
        clampRotationLow = Quaternion.Euler(0, 0, -70f);
        clampRotationHigh = Quaternion.Euler(0, 0, +70f);
    }

    // Update is called once per frame
    void Update()
    {
        PointAtMouse();

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet1Prefab, cannonTip.position, cannonTip.rotation);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(bullet2Prefab, cannonTip.position, cannonTip.rotation);
        }

    }


    private void PointAtMouse()
    {
       
        Vector3 relativePos = this.transform.position - GameData.MousePos;
        Quaternion newrotation = Quaternion.LookRotation(relativePos, Vector3.forward);
        newrotation.x = 0;
        newrotation.y = 0;
        newrotation.z = Mathf.Clamp(newrotation.z, clampRotationLow.z, clampRotationHigh.z);
        newrotation.w = Mathf.Clamp(newrotation.w, clampRotationLow.w, clampRotationHigh.w);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newrotation, Time.deltaTime * 3);
    }


}
