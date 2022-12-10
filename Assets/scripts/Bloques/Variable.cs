using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Referencias2 : MonoBehaviour
{
   public static Dictionary<string, int> variableInt = new Dictionary<string, int>();
   public static Dictionary<string, string> variableString = new Dictionary<string, string>();
   public static List<string> VariablePrint = new List<string>();
}
public class Variable : MonoBehaviour
{
    private string Nombre = "abanaba";
    private string String = "abanaba";
    private int Numero = 0;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void NombreVariable(string n)
    {
        Referencias2.variableInt.Remove(Nombre);
        Referencias2.variableString.Remove(Nombre);
        Referencias2.VariablePrint.Remove(Nombre);
        Nombre = n;
        Debug.Log(n);
        

    }

    public void NumeraVariable(string y)
    {
        Referencias2.variableInt.Remove(Nombre);
        Referencias2.variableString.Remove(Nombre);
        Referencias2.VariablePrint.Remove(Nombre);
        String = y;
        Debug.Log(y);
        int.TryParse(y, out Numero);
        Debug.Log(Numero);
        Referencias2.variableInt.Add(Nombre, Numero);
        Referencias2.variableString.Add(Nombre, String);
        Referencias2.VariablePrint.Add(Nombre);
        VariablePrint.Portos = true;

    }
    private void Update()
    {
        
        if (Nombre != null && String != null && Pythonchecker.WhichProgram == 3)
        {
            Referencias.TaskEdit[0] = true;
        }

    }
}
