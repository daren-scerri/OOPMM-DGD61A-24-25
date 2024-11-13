using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{

    public static Vector3 MousePos
    {
        get { return GetMousePos(); }
    }


    static Vector3 GetMousePos()
    {
        Camera myCamera = Camera.main;
        Vector3 mousePos = myCamera.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0f, 0f, 10f);
        return mousePos;
    }

}
