using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VariablePrint : MonoBehaviour
{
    private bool dropshotChanged;
    public Text TextBox;
    public static bool Portos = false;
    private int Deletepritos;
    public GameObject Canvas;
    public GameObject Imagen;
    private int edgar;
    private string Valtext;

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
    private void Awake()
    {
        edgar = Operaciones.Numeros;
    }
    private void Update()
    {
   
        
            var dropdown = transform.GetComponent<Dropdown>();
            dropdown.options.Clear();
            dropdown.options.Add(new Dropdown.OptionData() { text = "Variables:" });
            foreach (var item in Referencias2.VariablePrint)
            {
                dropdown.options.Add(new Dropdown.OptionData() { text = item });


            }
            
       
        if(Referencias.VarPrinIn == true && Valtext != null && Pythonchecker.WhichProgram == 2 ||  dropshotChanged == true && Referencias.VarPrinIn == true && Pythonchecker.WhichProgram == 2)
        {
            Referencias.TaskEdit[2] = true;
        }
        else
        {
            Referencias.TaskEdit[2] = false;
        }
        if(SlotPrint.PrintWithVar != null && dropshotChanged == true)
        {
            SlotPrint.PrintWithVar.GetComponent<TMP_InputField>().text = Valtext;
        }
    }

    public void Variables(int val)
    {
        //if (Imagen.tag == "VariablePrint")
        //{
        if (val >= 1)
        {

            Valtext = Referencias2.variableString[Referencias2.VariablePrint[val - 1]];
            dropshotChanged = true;
            return;
        }
        else
        {
            dropshotChanged = false;
        }
        //}

    }

}
    
