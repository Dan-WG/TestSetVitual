using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RielesMenuBttns : MonoBehaviour
{
    public GameObject rielesMenuBttns1, menuBttns1;

    public void MenuBttns1()
    {
        rielesMenuBttns1.SetActive(false);
        menuBttns1.SetActive(true);
    }
}
