using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBloquesa : MonoBehaviour
{
    private void Update()
    {
        if(ButtonClick.Destrozar == true)
        {
            Destroy(gameObject);
        }
    }
}
