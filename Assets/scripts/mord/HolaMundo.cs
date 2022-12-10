using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class HolaMundo : MonoBehaviour
{
    private static int b = 0;
    public GameObject DialogueBoton;
    public Text Prueba;
    private static int DIOS = 0;
    // Update is called once per frame
    void Update()
    {
        if(Prueba.text == Environment.NewLine+"Hola Mundo" && DIOS == 0)
        {
            if (b == 0)
            {
                var mousePosition = Camera.main.ScreenToWorldPoint(
                      Input.mousePosition
                  );
                // use 'Instantiate' to clone our prefab; this 3-arg version 
                // lets us set the position and rotation for the new object
                var newprint = Instantiate(
                    DialogueBoton,
                    new Vector3(mousePosition.x, mousePosition.y, 0),
                    Quaternion.identity
                );
                b = 1;
            }
            DIOS = 1;
        }
      
    }
}
