using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Utility;

public class Controles : MonoBehaviour
{

    public GameObject Cam1GO, UILuz, GoLuz, RootCamara, RootLuz;
    //Animator anim1;
    private bool active1, active2;
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
                active2= false;
                Cam1GO.gameObject.GetComponent<CameraController>().enabled = true;
                camera1 = Camera.main;
                Cam1GO.GetComponent<Camera>().enabled = true;
                Cam1GO.GetComponent<BajarRiel>().enabled = true;
                Cam1GO.GetComponent<CameraController>().enabled = true;
                Cam1GO.GetComponent<CharacterController>().enabled = true;
                RootCamara.GetComponent<ControlRiel>().enabled = true;
                RootCamara.GetComponentInChildren<ControlBrazo>().enabled = true;
                RootLuz.GetComponent<ControlRiel>().enabled = false;
                RootLuz.GetComponentInChildren<ControlBrazo>().enabled = false;
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
                RootCamara.GetComponent<ControlRiel>().enabled = false;
                RootCamara.GetComponentInChildren<ControlBrazo>().enabled = false;
                FPSControl.GetComponentInChildren<Camera>().enabled = true;
                FPSControl.GetComponent<FirstPersonController>().enabled = true;
                //FPSControl.gameObject.SetActive(true);
                //anim1.SetBool("Active", active1);
            }

        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            if (!active2)
            {
                active2 = true;
                active1 = false;
                UILuz.SetActive(true);

                RootLuz.GetComponent<ControlRiel>().enabled = true;
                RootLuz.GetComponentInChildren<ControlBrazo>().enabled = true;
                RootCamara.GetComponent<ControlRiel>().enabled = false;
                GoLuz.GetComponent<CameraController>().enabled = true;
               
                GoLuz.GetComponent<BajarRiel>().enabled = true;
                //FPSControl.GetComponentInChildren<Camera>().enabled = false;
                FPSControl.GetComponent<FirstPersonController>().enabled = false;

                RootCamara.GetComponent<ControlRiel>().enabled = false;
                RootCamara.GetComponentInChildren<ControlBrazo>().enabled = false;
                //FPSControl.gameObject.SetActive(false);
                //anim1.SetBool("Active", active1);
            }
            else
            {

                RootLuz.GetComponent<ControlRiel>().enabled = false;
                active2 = false;
                UILuz.SetActive(false);
                GoLuz.GetComponent<BajarRiel>().enabled = false;
                GoLuz.GetComponent<CameraController>().enabled = false;
                GoLuz.GetComponent<CharacterController>().enabled = false;


                FPSControl.GetComponent<FirstPersonController>().enabled = true;
                //FPSControl.gameObject.SetActive(true);
                //anim1.SetBool("Active", active1);
            }

        }

    }
}
