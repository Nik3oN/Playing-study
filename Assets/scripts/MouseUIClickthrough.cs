using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseUIClickthrough : MonoBehaviour
{
    public GameObject InputField;
    private string InputField1;
    private string InputField2;


    public void ReadInputF(string s)
    {
        InputField1 = InputField.GetComponent<Text>().text;
    }
    public void ReadInputS(string s)
    {
        InputField2 = s;
    }
}
