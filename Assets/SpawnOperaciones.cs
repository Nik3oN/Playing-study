using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOperaciones : MonoBehaviour
{
    public GameObject BloqueOperaciones;
    void Update()
    {
        DontDestroyOnLoad(BloqueOperaciones);
    }
    // Update is called once per frame
    public void BotonVariable()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(
                Input.mousePosition
            );
        // use 'Instantiate' to clone our prefab; this 3-arg version 
        // lets us set the position and rotation for the new object
        var newprint = Instantiate(
            BloqueOperaciones,
            new Vector3(mousePosition.x, mousePosition.y, 0),
            Quaternion.identity
        );
    }
}
