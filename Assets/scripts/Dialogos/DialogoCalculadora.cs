using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoCalculadora : MonoBehaviour
{
    private static int a = 0;
    public GameObject Dialogue4;

    // Update is called once per frame
    void Update()
    {
        if (a == 0)
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(
                  Input.mousePosition
              );
            // use 'Instantiate' to clone our prefab; this 3-arg version 
            // lets us set the position and rotation for the new object
            var newprint = Instantiate(
                Dialogue4,
                new Vector3(mousePosition.x, mousePosition.y, 0),
                Quaternion.identity
            );
            a = 1;
        }
    }
}
