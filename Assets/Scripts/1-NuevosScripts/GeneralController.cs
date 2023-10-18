using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GeneralController : MonoBehaviour
{
    public GameObject rielMovY, motorMovX, tubosMovZ1, tubosMovZ2;
    public TMP_InputField inputY, inputX, inputZ;

    private float x, y, z;

    private float z1, z2;

    private int limintY;

    private bool inputYbool = false;

    /*private void Awake()
    {
        inputX = transform.Find GetComponent<TMP_InputField>();
    }*/
    public void InputY()
    {
        y = float.Parse(inputY.text);
        //rielMovY.transform.localPosition = new Vector3(0, 0, -y);
        //Debug.Log(y);
    }

    public void InputX() 
    {
        x = float.Parse(inputX.text);
    }
    public void InputZ() 
    { 
        z = float.Parse(inputZ.text);
    }

    private void Update()
    {
        if (y >= 0)
        {
            rielMovY.transform.localPosition = Vector3.Lerp(rielMovY.transform.localPosition, new Vector3(0,0,-y), 0.01f);
        }
        if (x >= 0)
        {
            motorMovX.transform.localPosition = Vector3.Lerp(motorMovX.transform.localPosition, new Vector3(x, 0, 0), 0.01f);
        }
        if (z > 1.5f)
        {
            z1 = 1.5f;
            z2 = z - 1.5f;
            if (tubosMovZ1.transform.localPosition.z < z1)
            {
                tubosMovZ1.transform.localPosition = Vector3.Lerp(tubosMovZ1.transform.localPosition, new Vector3(0, -z1, 0), 0.01f);
                tubosMovZ2.transform.localPosition = Vector3.Lerp(tubosMovZ2.transform.localPosition, new Vector3(0, -z2, 0), 0.01f);
            }
        }
        else if (z < 1.5f)
        {
            tubosMovZ1.transform.localPosition = Vector3.Lerp(tubosMovZ1.transform.localPosition, new Vector3(0, -z, 0), 0.01f);
            tubosMovZ2.transform.localPosition = Vector3.Lerp(tubosMovZ2.transform.localPosition, new Vector3(0, 0, 0), 0.01f);
        }
        //else if (rielMovY.transform.localPosition.y > -y)
        //{
        //    rielMovY.transform.localPosition += new Vector3(0, 0, Time.deltaTime * 2f);
        //}
    }
}
