using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intruduzca : MonoBehaviour
{
    public static GameObject Intrdoduzir;
    public static bool activar = false;
    public static string Nombre;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void Introduzir(string a)
    {
        activar = true;
        Nombre = a;
        if (Pythonchecker.WhichProgram == 5)
        {
            Referencias.TaskEdit[1] = true;
        }
    }
}
