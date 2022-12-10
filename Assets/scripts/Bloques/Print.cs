using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Referencias : MonoBehaviour
{
    public static bool VarPrinIn;
    public static int CurrentApp;
    public static List<bool> TaskEdit = new(); 
    public static List<GameObject> IfObj = new();
    public static string input;
    public static List<string> Printos = new List<string>();
    public static List<GameObject> printas = new();
    public static List<GameObject> PrintObj = new();
    public static int NumeroPrints = -1;
    public static bool Passlvl1 = false;
    public static bool Passlvl2 = false;
    public static bool Passlvl3 = false;
    public static bool Passlvl4 = false;
    public static bool Passlvl5 = false;
    public static bool Passlvl6 = false;
    public static string TextInPrint;

    //public static void FindText(GameObject Obj, string text)
    //{
    //    text +=  Obj.transform.GetChild(0).GetChild(0).GetComponent<TMP_InputField>().text;
        
    //}
}
public class Print : MonoBehaviour
{
    private static string a = "a";
    private  int b ;
    public static int Detroys = 0;
    public GameObject Printos;

    private void Awake()
    {
        if (gameObject.name == "Printa(Clone)")
        {
            Referencias.TextInPrint = gameObject.transform.GetChild(0).GetChild(0).GetComponent<TMP_InputField>().text;
            Referencias.PrintObj.Add(gameObject);
            Referencias.Printos.Insert(b, null);
        }

        b = Referencias.NumeroPrints;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {

    }
    public void Printa(string s)

    {
        Referencias.TextInPrint = s;
        {
            if(Pythonchecker.WhichProgram == 1)
            {
                if (s == "Hello World" || s == "hello world" || s == "Hello world")
                {
                    Referencias.TaskEdit[1] = true;
                }
                else
                {
                    Referencias.TaskEdit[1] = false;
                }
            }
            if(Pythonchecker.WhichProgram == 4 && s!= null)
            {
                Referencias.TaskEdit[2] = true;
            }
            
        }
    }
}



