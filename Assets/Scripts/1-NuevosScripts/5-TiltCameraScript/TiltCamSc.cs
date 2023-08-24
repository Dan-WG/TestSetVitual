using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltCamSc : MonoBehaviour
{
    public GameObject tiltObj;

    private bool tiltUpDown = false;
    private bool tiltDownDown = false;

    public void TiltUpDOWN()
    {
        tiltUpDown = true;
    }

    public void TiltUpUP()
    {
        tiltUpDown = false;
    }

    public void TiltDownDOWN()
    {
        tiltDownDown = true;
    }

    public void TiltDownUP()
    {
        tiltDownDown = false;
    }

    private void Update()
    {
        if (tiltUpDown)
        {
            tiltObj.transform.Rotate(Vector3.right, 1f);
        }
        if (tiltDownDown)
        {
            tiltObj.transform.Rotate(Vector3.left, 1f);
        }
    }
}
