using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBloques : MonoBehaviour
{
    private GameObject Bloques;
    private GameObject Bloques2;


    // Update is called once per frame
    void Update()
    {


        Bloques = GameObject.FindGameObjectWithTag("PRINT");
        if (Bloques != null)
        {
            Destroy(Bloques);
            Referencias.NumeroPrints = -1;
            Referencias.Printos.Clear();
        }
        Bloques2 = GameObject.FindGameObjectWithTag("Variable");
        if (Bloques2 != null)
        {
            Destroy(Bloques2);
            Referencias2.variableInt.Clear();
            Referencias2.variableString.Clear();
        }
    }
}
