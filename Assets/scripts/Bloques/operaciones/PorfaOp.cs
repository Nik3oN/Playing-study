using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PorfaOp : MonoBehaviour
{
    private string DropDownInput2 = null;
    public Dropdown Signo;
    private int Var1 = -1 / 1000;
    private int Var2 = -1 / 1000;
    private int Variable;
    public static string Vartot;
    private bool lol = false;
    public static bool AllDoneOp;
    public void Variable1(int val)
    {
        Var1 = Referencias2.variableInt[Referencias2.VariablePrint[val - 1]];
        Debug.Log(Var1);
        lol = true;
    }
    public void Variable2(int val)
    {

        Var2 = Referencias2.variableInt[Referencias2.VariablePrint[val - 1]];
        Debug.Log(Var2);
        lol = true;
    }
    public void signo(int a)
    {

        DropDownInput2 = Signo.options[Signo.value].text;
        Debug.Log(DropDownInput2);
        lol = true;

    }
    private void Update()
    {
        if (Var1 != -1 / 1000 && Var2 != -1 / 1000 && DropDownInput2 != null && lol == true)
        {
            AllDoneOp = true;
            if(Pythonchecker.WhichProgram == 3)
            {
                Referencias.TaskEdit[2] = true;
            }
            
            lol = false;
                Debug.Log("A");
                if (DropDownInput2 == "+")
                {
                    Variable = Var1 + Var2;
                    Vartot = Variable.ToString();

                }
                if (DropDownInput2 == "-")
                {
                    Variable = Var1 - Var2;
                    Vartot = Variable.ToString();
                }
                if (DropDownInput2 == "*")
                {
                    Variable = Var1 * Var2;
                    Vartot = Variable.ToString();

                }
                if (DropDownInput2 == "/")
                {
                    Variable = Var1 / Var2;
                    Vartot = Variable.ToString();
                }
            
        }
        //else
        //{
        //    AllDoneOp = false;
        //}
    }
}
