using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BajarRiel : MonoBehaviour
{

    public GameObject Pieza2, pieza3;
    public int speed = 5;


    /*
     * pos2 5.1 0 y
     * pos3 4 .0 y
     * 
     * 
     * */

    private void Update()
    {
        UpDown();
        //Debug.Log("Pieza2: " + Pieza2.transform.position.y);
        //ebug.Log("Pieza3: " + pieza3.transform.position.y);

    }


    private void UpDown()
    {
        if (Input.GetKey(KeyCode.W))
        {

            if(Pieza2.transform.position.y <= 8.69f)
            {
                Pieza2.transform.position+= new Vector3(0, speed * Time.deltaTime, 0);
            }
            else if (pieza3.transform.position.y <= 8.69f)
            {
                pieza3.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            }

        }
        else if (Input.GetKey(KeyCode.S))
        {
           
            if (Pieza2.transform.position.y >= 7.2f)
            {
                Pieza2.transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
            }
            else if (pieza3.transform.position.y >= 5.96f)
            {
                pieza3.transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
            }
        }
    }
}
