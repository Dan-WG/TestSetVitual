using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ObjRotationController : MonoBehaviour
{
    public GameObject rotPiece;

    private bool ClockDown = false;
    private bool AnticlockDown = false;

    public void RotClockwsiePanDOWN() 
    {
        ClockDown = true;
    }

    public void RotClockwsiePanUP()
    {
        ClockDown = false;
    }

    public void RotAnticlockwsiePanDOWN()
    {
        AnticlockDown = true;
    }

    public void RotAnticlockwsiePanUP()
    {
        AnticlockDown = false;
    }

    private void Update()
    {
        if (ClockDown) 
        {
            rotPiece.transform.Rotate(Vector3.forward, 1f);
        }
        if (AnticlockDown)
        {
            rotPiece.transform.Rotate(Vector3.forward, -1f);
        }
    }
}
