using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVariablPrint : MonoBehaviour
{
    public GameObject BloqueVariablePrint;
    void Awake()
    {
        DontDestroyOnLoad(BloqueVariablePrint);
    }

    public void BotonVariablePrint()
    {

        // get the mouse click position, in world units
        var mousePosition = Camera.main.ScreenToWorldPoint(
                Input.mousePosition
            );
        // use 'Instantiate' to clone our prefab; this 3-arg version 
        // lets us set the position and rotation for the new object
        var newBloqueVariable = Instantiate(
            BloqueVariablePrint,
            new Vector3(mousePosition.x, mousePosition.y, 0),
            Quaternion.identity
        );

    }
}
