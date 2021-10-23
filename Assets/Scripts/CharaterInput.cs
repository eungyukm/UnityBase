using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterInput : MonoBehaviour
{
    public string moveAxisName = "Vertical";
    public string rotateAxisName = "Horizontal";

    public float move
    {
        get;
        private set;
    }

    public float rotate
    {
        get;
        private set;
    }

    private void Update()
    {
        move = Input.GetAxis(moveAxisName);
        rotate = Input.GetAxis(rotateAxisName);

        Debug.Log("move : " + move);
        Debug.Log("rotate : " + rotate);
    }
}
