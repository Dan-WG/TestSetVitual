using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class RielesController : MonoBehaviour
{
    public GameObject rielTras1;
    public GameObject rielTras2;

    [SerializeField] private float speed = 2f;

    private bool onPointerDown1 = false;
    private bool onPointerDown2 = false;

    private Vector3 temp;

    public void MoveForwardRiel1Down()
    {
        onPointerDown1 = true;
    }

    public void MoveForwardRiel1Up()
    {
        onPointerDown1 = false;
    }

    public void MoveBackwardsRiel1Down()
    {
        onPointerDown2 = true;
    }

    public void MoveBackwardsRiel1Up()
    {
        onPointerDown2 = false;
    }

    void Update()
    {
        temp = rielTras1.transform.localPosition;
       
        if (onPointerDown1 && (temp.z < 0))
        {
            rielTras1.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }

        if(onPointerDown2 && (temp.z > -54f))
        {
            rielTras1.transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
        }
    }
}
