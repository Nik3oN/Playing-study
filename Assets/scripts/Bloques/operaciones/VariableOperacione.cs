using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VariableOperacione : MonoBehaviour
{
    public Text TextBox;
    public static bool Portos = false;
    private int Deletepritos;
    public GameObject Canvas;
    public GameObject Imagen;
    private int edgar;
    public static int Edgar = -1;
    private List<string> Variable = new List<string>();
    private void Awake()
    {
        Edgar = Edgar + 1;
        edgar = Edgar;
    }
    private void FixedUpdate()
    {
        
    
        if(Variable1.Var1 != null)
        {
            DontDestroyOnLoad(gameObject);
            var dropdown = transform.GetComponent<Dropdown>();
            dropdown.options.Clear();
            dropdown.options.Add(new Dropdown.OptionData() { text = "Variables:" });
            foreach (var item in Referencias2.VariablePrint)
            {

                dropdown.options.Add(new Dropdown.OptionData() { text = item });


            }
        }
    }
    public void Variables(int val)
    {
        if(Variable1.Var1 != null)
        {
            if (Imagen.tag == "Variable1")
            {
                Variable1.Var1.RemoveAt(edgar);
                Variable1.Var1.Insert(edgar, Referencias2.variableInt[Referencias2.VariablePrint[val - 1]]);

            }
            if (Imagen.tag == "Variable2")
            {
                Variable2.Var2.RemoveAt(edgar);
                Variable2.Var2.Insert(edgar, Referencias2.variableInt[Referencias2.VariablePrint[val - 1]]);
            }
        }
        
    }
    private void Update()
 {
    if (Variable != Referencias2.VariablePrint)
    {
        var dropdown = transform.GetComponent<Dropdown>();
        dropdown.options.Clear();
        dropdown.options.Add(new Dropdown.OptionData() { text = "Variables:" });
        foreach (var item in Referencias2.VariablePrint)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });


        }
            Variable = Referencias2.VariablePrint;
    }

 }
}
