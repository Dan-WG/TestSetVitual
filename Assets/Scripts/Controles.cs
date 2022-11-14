using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Utility;

public class Controles : MonoBehaviour
{

    public GameObject Cam1GO;
    //Animator anim1;
    private bool active1;
    public Camera camera1;
    public GameObject FPSControl;
    public Camera FPSCam;
    

    // Start is called before the first frame update
    void Start()
    {
        //anim1 = Cam1.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            if (!active1)
            {
                active1 = true;
                Cam1GO.gameObject.GetComponent<CameraController>().enabled = true;
                camera1 = Camera.main;
                Cam1GO.GetComponent<Camera>().enabled = true;
                Cam1GO.GetComponent<BajarRiel>().enabled = true;
                FPSControl.GetComponentInChildren<Camera>().enabled = false;
                FPSControl.GetComponent<FirstPersonController>().enabled = false;
                //FPSControl.gameObject.SetActive(false);
                //anim1.SetBool("Active", active1);
            }
            else 
            {

                Cam1GO.gameObject.GetComponent<CameraController>().enabled = false;
                active1 = false;
                FPSCam = Camera.main;
                Cam1GO.GetComponent<Camera>().enabled = false;
                Cam1GO.GetComponent<BajarRiel>().enabled = false;
                FPSControl.GetComponentInChildren<Camera>().enabled = true;
                FPSControl.GetComponent<FirstPersonController>().enabled = true;
                //FPSControl.gameObject.SetActive(true);
                //anim1.SetBool("Active", active1);
            }

        }
        
    }
}
