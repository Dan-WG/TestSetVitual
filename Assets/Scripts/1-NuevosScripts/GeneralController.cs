using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralController : MonoBehaviour
{
    public GameObject rielMov1;
    public GameObject rielMov2;

    public void RielMov1()
    {
        if (Input.GetKey(KeyCode.W) && (rielMov1.transform.position.z <= 12f))
        {
            rielMov1.transform.position += new Vector3(0, 0, 1f);
        }
        if (Input.GetKey(KeyCode.S) && (rielMov1.transform.position.z >= -41f))
        {
            rielMov1.transform.position += new Vector3(0, 0, -1f);
        }
    }

}
