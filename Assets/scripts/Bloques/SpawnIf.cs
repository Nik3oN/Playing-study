using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIf : MonoBehaviour
{
    public GameObject IfBlock;

    void Awake()
    {
        DontDestroyOnLoad(IfBlock);
    }
    public void BotonIf()
    {

        IfBlock.GetComponentInChildren<Canvas>().GetComponent<Canvas>().sortingOrder = 1;
        var mousePosition = Camera.main.ScreenToWorldPoint(
                Input.mousePosition
            );
        // use 'Instantiate' to clone our prefab; this 3-arg version 
        // lets us set the position and rotation for the new object
        var newprint = Instantiate(
            IfBlock,
            new Vector3(mousePosition.x, mousePosition.y, 0),
            Quaternion.identity
        );
        if(Pythonchecker.WhichProgram == 4 )
        {
            Referencias.TaskEdit[0] = true;
        }

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Trigger!");

    }
}
