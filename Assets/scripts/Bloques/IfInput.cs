using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfInput : MonoBehaviour
{
    private bool FirstInput = false;
    private bool SecondInput = false;
    private bool ThirdInput = false;
    private int? InputField1;
    private int? InputField2;
    private string DropDownInput;
    public Dropdown DropDownobj;
    public static bool Acces;

    public void Awake()
    {
        if (gameObject.name == "If(Clone)")
        {
            Referencias.IfObj.Add(gameObject);
        }
        Acces = false;
        DontDestroyOnLoad(gameObject);
    }
    public void ReadInputF(string s)
    {
        InputField1 = int.Parse(s);
        Acces = false;
           
    }
    public void ReadInputS(string s)
    {
        InputField2 = int.Parse(s);
        Acces = false;
    }

    public void ReadDropDown()
    {
        DropDownInput = DropDownobj.options[DropDownobj.value].text;
        Acces = false;

    }
    public void Update()
    {
        if (Pythonchecker.WhichProgram == 4 && Acces == true)
        {
            Referencias.TaskEdit[3] = true;
        }
        if (DropDownInput != null)
        {
            ThirdInput = true;
            
        }
        if (InputField2 != null)
        {
            SecondInput = true;
            
        }
        if (InputField1 != null)
        {
            FirstInput = true;
            
        }
        if (FirstInput == true && SecondInput == true && ThirdInput == true && ItemSlot.InIf == true)
        {
            
            if (DropDownInput == "==")
            {
                
                if (InputField1 == InputField2)
                {
                    Acces = true;



                }
            }
            if (DropDownInput == "!=")
            {
                if (InputField1 != InputField2)
                {
                    Acces = true;
                    
                }
            }
            if (DropDownInput == "<")
            {
                if (InputField1 < InputField2)
                {
                    Acces = true;
                    
                }
            }
            if (DropDownInput == ">")
            {
                if (InputField1 > InputField2)
                {
                    Acces = true;
                   
                }
            }
            if (DropDownInput == "<=")
            {
                if (InputField1 <= InputField2)
                {
                    Acces = true;
                    
                }
            }
            if (DropDownInput == ">=")
            {
                if (InputField1 >= InputField2)
                {
                    Acces = true;
                    
                }
            }
        }
    }

}
