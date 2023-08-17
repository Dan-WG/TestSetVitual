using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubosController : MonoBehaviour
{
    public GameObject tubo1;

    [SerializeField] private float speed = 2f;

    private bool rigthDown1 = false;
    private bool leftDown1 = false;

    private Vector3 temp;

    public void MoveRightTubo1Down()
    {
        rigthDown1 = true;
    }

    public void MoveRightubo1Up()
    {
        rigthDown1 = false;
    }

    public void MoveLeftTubo1Down()
    {
        leftDown1 = true;
    }

    public void MoveLeftTubo1Up()
    {
        leftDown1 = false;
    }

    void Update()
    {
        temp = tubo1.transform.position;

        if (rigthDown1 && (temp.x < 30f))
        {
            tubo1.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (leftDown1 && (temp.x > 4f))
        {
            tubo1.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }
}
