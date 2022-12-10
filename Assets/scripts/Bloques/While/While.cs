using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class While : MonoBehaviour
{
    public GameObject Canvas;
    public static List<int> VariableWhile = new();
    private int Deletepritos;
    private string DropDownInput = null;
    private string DropDownInput2 = null;
    public Dropdown Signo;
    public Dropdown Signo2;
    public Dropdown DropDownobj;
    public Dropdown DropDownobj2;
    private int Variable = -1 / 1000;
    private int Dios = -1 / 1000;
    private int Var1 = -1 / 1000;
    private int Var2 = -1 / 1000;
    private int VarRepetir;
    private int a;
    public static bool funcion = false;
    public static List<string> Escribir = new();
    private bool abc = false;
    void Start()
    {
        DontDestroyOnLoad(Canvas);
        var dropdown = transform.GetComponent<Dropdown>();
        dropdown.options.Clear();
        dropdown.options.Add(new Dropdown.OptionData() { text = "Variables:" });
        foreach (var item in Referencias2.VariablePrint)
        {

            dropdown.options.Add(new Dropdown.OptionData() { text = item });


        }

    }
    private void Update()
    {
        if (VariablePrint.Portos == true)
        {
            var dropdown = transform.GetComponent<Dropdown>();
            dropdown.options.Clear();
            dropdown.options.Add(new Dropdown.OptionData() { text = "Variables:" });
            foreach (var item in Referencias2.VariablePrint)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });


            }
            VariablePrint.Portos = false;
        }
        if (abc == true)
        {
            While1();
        }

    }
    public void VariableTor(int val)
    {
        Escribir.Clear();
        Variable = Referencias2.variableInt[Referencias2.VariablePrint[val - 1]];
        Debug.Log(Variable);
        ABC();
    }
    public void signo(int a)
    {
        Escribir.Clear();
        DropDownInput = Signo.options[Signo.value].text;
        Debug.Log(DropDownInput);
        ABC();
    }
    public void numero(string a)
    {
        Escribir.Clear();
        int.TryParse(a, out Dios);
        Debug.Log(Dios);
        ABC();
    }
    public void signoOperacion(int val)
    {
        Escribir.Clear();
        DropDownInput2 = Signo2.options[Signo2.value].text;
        Debug.Log(DropDownInput2);
        ABC();
    }
    public void Variable1(int val)
    {
        Escribir.Clear();
        VarRepetir = Var1;
        Var1 = Referencias2.variableInt[Referencias2.VariablePrint[val - 1]];
        Debug.Log(Var1);
        ABC();
    }
    public void Variable2(int val)
    {
        Escribir.Clear();
        Var2 = Referencias2.variableInt[Referencias2.VariablePrint[val - 1]];
        Debug.Log(Var2);
        
        ABC();
    }
    private void ABC()
    {
        if (Dios != -1 / 1000 && Var1 != -1 / 1000 && Var2 != -1 / 1000 && Variable != -1 / 1000)
        {
            abc = true;
            Debug.Log(abc);
        }
        else
        {
            abc = false;
        }
    }
    private void Op()
    {

        if (DropDownInput2 == "+")
        {

            Variable = Var1 + Var2;
            Escribir.Add(Var1.ToString() + " + " + Var2.ToString() + " = " + Variable.ToString());
            Var1 = Variable;
        }
        if (DropDownInput2 == "-")
        {
            Variable = Var1 - Var2;
            Escribir.Add(Var1.ToString() + " - " + Var2.ToString() + " = " + Variable.ToString());
            Var1 = Variable;
        }
        if (DropDownInput2 == "*")
        {
            Variable = Var1 * Var2;
            Escribir.Add(Var1.ToString() + " * " + Var2.ToString() + " = " + Variable.ToString());
            Var1 = Variable;
        }
        if (DropDownInput2 == "/")
        {
            Variable = Var1 / Var2;
            Escribir.Add(Var1.ToString() + " / " + Var2.ToString() + " = " + Variable.ToString());
            Var1 = Variable;
        }
    }
    private void Terminar()
    {
        Referencias.Passlvl6 = true;
        if (Pythonchecker.WhichProgram == 6)
        {
            Referencias.TaskEdit[2] = true;
            Referencias.Passlvl6 = true;

        }
        Escribir.Add("While termindo");
        abc = false;
        Var1 = VarRepetir;
    }

    private void While1()
    {



        if (DropDownInput == "==")
        {
            Debug.Log("a");
            if (Variable == Dios)
            {
                Debug.Log("Dios");
                Op();
            }
            else
            {
                Terminar();
            }
        }
        if (DropDownInput == "!=")
        {
            if (Variable != Dios)
            {
                Op();
            }
            else
            {
                Terminar();
            }
        }
        if (DropDownInput == "<")
        {
            if (Variable < Dios)
            {
                Op();
            }
            else
            {
                Terminar();
            }
        }
        if (DropDownInput == "<=")
        {
            if (Variable <= Dios)
            {
                Op();
            }
            else
            {
                Terminar();
            }
        }
        if (DropDownInput == ">")
        {
            if (Variable <= Dios)
            {
                Op();
            }
            else
            {
                Terminar();
            }
        }
        if (DropDownInput == ">=")
        {
            if (Variable <= Dios)
            {
                Op();
            }
            else
            {
                Terminar();
            }

        }

    }
}




