using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterInput : MonoBehaviour
{
    public string vertical = "Vertical";
    public string horizontal = "Horizontal";

    public float verticalInput
    {
        get;
        private set;
    }

    public float horizontalInput
    {
        get;
        private set;
    }

    private void Update()
    {
        verticalInput = Input.GetAxis(vertical);
        horizontalInput = Input.GetAxis(horizontal);

        //Debug.Log("move : " + move);
        //Debug.Log("rotate : " + rotate);
    }
}
