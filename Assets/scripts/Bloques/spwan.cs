using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwan : MonoBehaviour
{
    public GameObject print;

    void Awake()
    {
        DontDestroyOnLoad(print);
    }
    
    public void BotonPrint()
    {
        if(Pythonchecker.WhichProgram == 1)
        {
            Referencias.TaskEdit[0] = true;
        }
        if(Pythonchecker.WhichProgram == 2)
        {
            Referencias.TaskEdit[1] = true;
        }
        if (Pythonchecker.WhichProgram == 5)
        {
            Referencias.TaskEdit[0] = true;
        }
        if (Pythonchecker.WhichProgram == 6)
        {
            Referencias.TaskEdit[0] = true;
        }
        if(Pythonchecker.WhichProgram == 3)
        {
            Referencias.TaskEdit[0] = true;
        }
        Debug.Log("a");
        Referencias.NumeroPrints = Referencias.NumeroPrints+1;
        // get the mouse click position, in world units
        var mousePosition = Camera.main.ScreenToWorldPoint(
                Input.mousePosition
            );
            // use 'Instantiate' to clone our prefab; this 3-arg version 
            // lets us set the position and rotation for the new object
            var newprint = Instantiate(
                print,
                new Vector3(mousePosition.x, mousePosition.y, 0),
                Quaternion.identity
            );
       
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Trigger!");

    }
}
