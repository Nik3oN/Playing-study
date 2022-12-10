using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public static bool EscritorioCurrent;
    public static bool Destrozar = false;
   public void OpenApp(string sceneName)
    {
        Destrozar = false;
        if(sceneName == "Escritorio" && Pythonchecker.WhichProgram == 5 && Referencias.TaskEdit[1] == true)
        {
            Referencias.Passlvl5 = true;
        }
        if (sceneName == "Escritorio")
        {
            Destrozar = true;
            Debug.Log(Destrozar);
            Referencias.TaskEdit = new();
            Referencias.Printos = new();
            Referencias.PrintObj = new();
            Referencias2.VariablePrint = new();
            Referencias2.variableInt = new();
            Referencias2.variableString = new();
            Operaciones.Vartot = new();
            Variable1.Var1 = new();
            Variable2.Var2 = new();
            SceneManager.LoadScene(sceneName);
            While.Escribir = new();
            return;
        }
        if (sceneName == "PowerPoint" && Pythonchecker.WhichProgram != 2)
        {
            return;
        }
        if(sceneName == "Calculator" &&Pythonchecker.WhichProgram != 3)
        {
            return;
        }
        if (sceneName == "Lexe" && Pythonchecker.WhichProgram != 4)
        {
            return;
        }
        if (sceneName == "Valorancia" && Pythonchecker.WhichProgram != 5)
        {
            return;
        }
        if (sceneName == "While Hero" && Pythonchecker.WhichProgram != 6)
        {
            return;
        }
        if (sceneName == "C")
        if (sceneName == "App1Console")
        {
            Referencias.CurrentApp = 1;
            SceneManager.LoadScene(sceneName);
            return;
        }
        if (sceneName == "App2 Console")
        {
            Referencias.CurrentApp = 2;
            SceneManager.LoadScene(sceneName);
            return;
        }
        else
        {
            SceneManager.LoadScene(sceneName);
            return;
        }
            
           
        
                
    }
   
}
