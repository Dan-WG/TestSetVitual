using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{

    [SerializeField] GameObject Cam1;
    Animator anim1;
    private bool active1;

    // Start is called before the first frame update
    void Start()
    {
        anim1 = Cam1.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!active1)
            {
                active1 = true;
                anim1.SetBool("Active", active1);
            }
            else 
            {
                active1 = false;
                anim1.SetBool("Active", active1);
            }

        }
        
    }
}
