using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
public class MordBloques : MonoBehaviour
{

    public Text BloquesPrint;
    public static bool Putas = true;
    void Start()
    {
        //Pythonchecker.WhichProgram = 2;
        BloquesPrint.text = null;
        if(Putas == false)
        {
            BloquesPrint.text = "";
            Putas = true;
        }
        if (Pythonchecker.WhichProgram == 6)
        {
            foreach (var item in While.Escribir)
            {

                BloquesPrint.text += item + "\n";
            }
        }
        if (Referencias.TaskEdit[1] == true && Referencias.TaskEdit[0] == true && Pythonchecker.WhichProgram == 1)
        {
            Referencias.Passlvl1 = true;

        }
        if (Referencias.TaskEdit[1] == true && Referencias.TaskEdit[0] == true && Pythonchecker.WhichProgram == 2 && Referencias.TaskEdit[2] == true)
        {
            Referencias.Passlvl2 = true;
        }

        if (Referencias.TaskEdit[1] == true && Referencias.TaskEdit[0] == true && Pythonchecker.WhichProgram == 4 && Referencias.TaskEdit[2] == true && Referencias.TaskEdit[3])
        {
            Referencias.Passlvl4 = true;
        }
        if (Referencias.TaskEdit[1] == true && Referencias.TaskEdit[0] == true && Pythonchecker.WhichProgram == 3 && Referencias.TaskEdit[2] == true && Referencias.TaskEdit[3])
        {
            Referencias.Passlvl3 = true;
        }
        if (Referencias.TaskEdit[1] == true && Referencias.TaskEdit[0] == true && Pythonchecker.WhichProgram == 5 && Referencias.TaskEdit[2] == true && Referencias.TaskEdit[3])
        {
            Referencias.Passlvl5 = true;
        }
        if (Referencias.TaskEdit[1] == true && Referencias.TaskEdit[0] == true && Pythonchecker.WhichProgram == 6 && Referencias.TaskEdit[2] == true)
        {
            Referencias.Passlvl6 = true;
        }
        if (Referencias.Printos.Count > 0)
        {
            Debug.Log("1");
            

            foreach (GameObject obj in Referencias.PrintObj)
            {
                BloquesPrint.text += Environment.NewLine + obj.transform.GetChild(0).GetChild(0).GetComponent<TMP_InputField>().text;
                
            }

        }
    }


}
