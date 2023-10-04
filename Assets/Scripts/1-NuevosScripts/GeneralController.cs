using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GeneralController : MonoBehaviour
{
    public GameObject rielMovY, motorMovX, tubosMovZ;
    public TMP_InputField inputY;

    private int x, y, z;

    private int limintY;

    private bool inputYbool = false;

    /*private void Awake()
    {
        inputX = transform.Find GetComponent<TMP_InputField>();
    }*/
    public void InputY()
    {
        inputYbool = true;
        y = Convert.ToInt32(inputY.text);
        //rielMovY.transform.localPosition = new Vector3(0, 0, y);
        //Debug.Log(inputY.text);
    }

    private void Update()
    {
        if (inputYbool) 
        {
            Debug.Log(inputYbool);
            //if(limintY < y)
            //rielMovY.transform.localPosition += new Vector3(0, 0, y);
        }
    }
}
