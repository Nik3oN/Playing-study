using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirBloque : MonoBehaviour
{
    public GameObject Printa;
    public void Bloquedestruido()
    {
        Printa = GameObject.Find("Printa");
        Destroy(Printa);
    }
}
