using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;

public class ControlesLuz : MonoBehaviour
{
    [SerializeField]
    private Slider Intensidad, angulo, rango;
    [SerializeField]
    private Light luz;


    public void CambiarIntensidad()
    {
        luz.intensity = Intensidad.value; 
    }

    public void CambiarAngulo()
    {
        luz.spotAngle = angulo.value;
    }

    public void CambiarRango()
    {
        luz.range = rango.value;
    }
}
