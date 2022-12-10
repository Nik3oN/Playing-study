using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operaciones : MonoBehaviour
{

    public static int Numeros = -1;
    private int Numerosprivata;
    private int operacione;
    public GameObject Vari1;
    public GameObject Vari2;
    public static List<int> Vartot = new();
    public static int Result;
    public static List<GameObject> OperObj = new();
    private void Awake()
    {
        OperObj.Add(gameObject);
        Numeros += 1;
        Numerosprivata = Numeros;
        DontDestroyOnLoad(gameObject);
    }
    public void operaciones(int signo)
    {
        Vartot.RemoveAt(Numeros);
        if(signo == 1)
        {
            Debug.Log("+");
            Vartot[OperObj.IndexOf(gameObject)] = Variable1.Var1[Numeros] + Variable2.Var2[Numeros];
            Result = Variable1.Var1[Numeros] + Variable2.Var2[Numeros];
        }
        if (signo == 2)
        {
            Debug.Log("-");
            Vartot.Insert(Numeros, Variable1.Var1[Numeros] - Variable2.Var2[Numeros]);
            Result = Variable1.Var1[Numeros] - Variable2.Var2[Numeros];
        }
        if (signo == 3)
        {
            Debug.Log("*");
            Vartot.Insert(Numeros, Variable1.Var1[Numeros] * Variable2.Var2[Numeros]);
            Result = Variable1.Var1[Numeros] * Variable2.Var2[Numeros];
        }
        if (signo == 4)
        {
            Debug.Log("/");
            Vartot.Insert(Numeros, Variable1.Var1[Numeros] / Variable2.Var2[Numeros]);
            Result = Variable1.Var1[Numeros] / Variable2.Var2[Numeros];
        }
        Debug.Log(Result);
    }

    
}
