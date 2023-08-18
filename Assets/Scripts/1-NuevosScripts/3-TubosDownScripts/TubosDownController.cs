using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubosDownController : MonoBehaviour
{
    public GameObject tuboRetract1;
    public GameObject tuboRetract2;

    [SerializeField] private float speed = 2f;

    private bool tuboRetDown1 = false;
    private bool tuboRetUp1 = false;

    private bool tubo1Total = false, tubo2Total = false;    

    private Vector3 temp, temp2;

    public void MoveTuboRetDown1Down()
    {
        tuboRetDown1 = true;
    }

    public void MoveTuboRetDown1Up()
    {
        tuboRetDown1 = false;
    }

    public void MoveTuboRetUp1Down()
    {
        tuboRetUp1 = true;
    }

    public void MoveTuboRetUp1Up()
    {
        tuboRetUp1 = false;
    }

    void Update()
    {
        temp = tuboRetract1.transform.localPosition;
        temp2 = tuboRetract2.transform.localPosition;

        if (tuboRetDown1)
        {
            if (temp.y < 5f)
                tuboRetract1.transform.localPosition += new Vector3(0, speed * Time.deltaTime, 0);
            else
                tubo1Total = true;
            
            if (tubo1Total) 
            {
                if (temp2.y < 4f)
                {
                    tubo2Total = false;
                    tuboRetract2.transform.localPosition += new Vector3(0, speed * Time.deltaTime, 0);
                }
                else
                    tubo2Total = true;
            }
        }

        if (tuboRetUp1)
        {
            if (tubo1Total) 
            {
                if(temp2.y > 0)
                    tuboRetract2.transform.localPosition -= new Vector3(0, speed * Time.deltaTime, 0);
                else 
                    tubo1Total = false;
            }

            if(!tubo1Total && temp.y > 0)
                tuboRetract1.transform.localPosition -= new Vector3(0, speed * Time.deltaTime, 0);
        }
    }
}
