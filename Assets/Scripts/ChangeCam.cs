using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    public Camera FPSCam;
    public Camera FreeCam;
    public GameObject FPSControl;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Key pressed");
            if(FPSCam = Camera.main)
            {
                Debug.Log("FPS is main");
                FreeCam = Camera.main;
                //FreeCam.gameObject.GetComponent<FreeCam>().enabled = true;
                //FPSControl.gameObject.SetActive(false);
            }
            else
            {
                FPSCam = Camera.main;
                //FreeCam.gameObject.GetComponent<FreeCam>().enabled = false;

                //FPSControl.gameObject.SetActive(true);
            }
        }
    }
}
