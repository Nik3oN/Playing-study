using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Introduzido : MonoBehaviour
{
    public GameObject introducir;
    public GameObject boton;
    public Text Nombrea;
    private void Start()
    {
        
        if ( Intruduzca.activar == true)
        {
            introducir.SetActive(true);
            Nombrea.text = Intruduzca.Nombre;
            if (Pythonchecker.WhichProgram == 5)
            {
                Referencias.TaskEdit[2] = true;
            }
        }
    }
    public void PassarNivel()
    {
        boton.SetActive(true);
    }
}
