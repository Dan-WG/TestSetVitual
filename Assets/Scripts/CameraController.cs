using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;

[RequireComponent(typeof(CharacterController))]

public class CameraController : MonoBehaviour
{
    public float speed;

    private float yaw = 0.0f;
    private float pitch = 0.0f;


    private void Update()
    {
        RotateCam();

    }

    void RotateCam()
    {
        yaw += speed * Input.GetAxis("Mouse X");
        pitch -= speed * Input.GetAxis("Mouse Y");


        pitch = Mathf.Clamp(pitch, -50f, 210f);
  

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}



