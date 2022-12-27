using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBrazo : MonoBehaviour
{
    public float speed;
    float PosX;
    public float VelocidadConst;
    public bool moveA = false;
    public bool moveD = false;

    private void Start()
    {
        PosX = transform.position.x;
    }

    void Update()
    {
        CheckPos();
        //VelocidadFija();

        if (Input.GetKey(KeyCode.UpArrow) && PosX <= 29f)
        {
            PosX += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && PosX >= 4f)
        {
            PosX -= speed * Time.deltaTime;
        }

        //Debug.Log(PosX);
        transform.position = new Vector3(PosX, transform.position.y, transform.position.z);
    }


    void VelocidadFija()
    {

        if (Input.GetKeyDown(KeyCode.H))
        {
            moveA = true;
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            moveD = true;
        }

        if (PosX <= 29f && moveA)
        {
            PosX += VelocidadConst * Time.deltaTime;
        }
        else if ((PosX >= 3f && moveD))
        {
            PosX -= VelocidadConst * Time.deltaTime;
        }

        
    }


    void CheckPos()
    {
        if (PosX >= 29f)
        {
            moveA = false;
        }
        else if (PosX <= 4f)
        {
            moveD = false;
        }
    }
}
