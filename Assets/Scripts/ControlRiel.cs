using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRiel : MonoBehaviour
{
    public float speed;
    float PosZ;
    public float VelocidadConst;
    public bool moveA = false;
    public bool moveD = false;

    private void Start()
    {
        PosZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        CheckPos();
        VelocidadFija();
        
        if (Input.GetKey(KeyCode.P) && PosZ <= 44f)
        {
            PosZ += speed * Time.deltaTime;
        }else if(Input.GetKey(KeyCode.O) && PosZ >= 3f)
        {
            PosZ -= speed * Time.deltaTime;
        }

        transform.position = new Vector3(transform.position.x, transform.position.y, PosZ);
    }


    void VelocidadFija()
    {
        
        if (Input.GetKeyDown(KeyCode.U))
        {
            moveA = true;
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            moveD = true;
        }

        if (PosZ <= 44f && moveA)
        {
            PosZ += VelocidadConst * Time.deltaTime;
        }
        else if ((PosZ >= 3f && moveD))
        {
            PosZ -= VelocidadConst * Time.deltaTime;
        }

        //Debug.Log(PosZ);
    }


    void CheckPos()
    {
        if(PosZ >= 43.5)
        {
            moveA = false;
        }
        else if (PosZ <= 3f)
        {
            moveD = false;
        }
    }
}
