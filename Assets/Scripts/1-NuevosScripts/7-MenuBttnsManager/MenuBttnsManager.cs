using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBttnsManager : MonoBehaviour
{
    public GameObject rielBttns, motorBttns, tubosBttns, panBttns, tiltBttns;
    public GameObject rielesMenuBttns, menuBttns;

    public void RielBttn()
    {
        rielBttns.SetActive(true);
        motorBttns.SetActive(false);
        tubosBttns.SetActive(false);
        panBttns.SetActive(false);
        tiltBttns.SetActive(false);
    }

    public void MotorBttn()
    {
        rielBttns.SetActive(false);
        motorBttns.SetActive(true);
        tubosBttns.SetActive(false);
        panBttns.SetActive(false);
        tiltBttns.SetActive(false);
    }

    public void TubosBttn()
    {
        rielBttns.SetActive(false);
        motorBttns.SetActive(false);
        tubosBttns.SetActive(true);
        panBttns.SetActive(false);
        tiltBttns.SetActive(false);
    }

    public void PanBttn()
    {
        rielBttns.SetActive(false);
        motorBttns.SetActive(false);
        tubosBttns.SetActive(false);
        panBttns.SetActive(true);
        tiltBttns.SetActive(false);
    }

    public void TiltBttn()
    {
        rielBttns.SetActive(false);
        motorBttns.SetActive(false);
        tubosBttns.SetActive(false);
        panBttns.SetActive(false);
        tiltBttns.SetActive(true);
    }

    public void BackBttn()
    {
        rielesMenuBttns.SetActive(true);
        menuBttns.SetActive(false);
        rielBttns.SetActive(false);
        motorBttns.SetActive(false);
        tubosBttns.SetActive(false);
        panBttns.SetActive(false);
        tiltBttns.SetActive(false);
    }
}
