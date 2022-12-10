using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TaskPanel : MonoBehaviour
{
    public int CuantityOfTasks;
    public Text Task1;
    public Text Task2;
    public Text Task3;
    public Text Task4;
    private bool Hide;
    private Vector2 Open = new Vector2(-530, -360);
    private Vector2 Close = new Vector2(-530, -690);
    private void Start()
    {
        
        for (int i = 0; i != 4; i++)
        {
            Referencias.TaskEdit.Add(false);
        }
        gameObject.transform.localPosition = Open;
        Hide = false;
    }
    private void Awake()
    {
        //Pythonchecker.WhichProgram = 2;
        
        if (Pythonchecker.WhichProgram == 1)
        {
            Task1.text = "Crea la funcion print()";
            Task1.color = Color.red;
            Task2.text = "Escribe 'Hello World'";
            Task2.color = Color.red;
        }
        if (Pythonchecker.WhichProgram == 2)
        {
            Task1.text = "Crea la variable con un nombre y un valor";
            Task1.color = Color.red;
            Task2.text = "Crea la funcion print()";
            Task2.color = Color.red;
            Task3.text = "Pon el bloque azul de variable en la parte blanca del print";
            Task3.color = Color.red;
        }
        if (Pythonchecker.WhichProgram == 3)
        {
            Task1.text = "Crea el print()";
            Task1.color = Color.red;
            Task2.text = "Crea 2 variables";
            Task2.color = Color.red;
            Task3.text = "Pon las variables en operaciones y el signo";
            Task3.color = Color.red;
            Task4.text = "Pon operaciones en el print";
            Task4.color = Color.red;
        }
        if (Pythonchecker.WhichProgram == 4)
        {
            Task1.text = "Crea el If";
            Task1.color = Color.red;
            Task2.text = "Coloca el Print en Acción";
            Task2.color = Color.red;
            Task3.text = "Escribe algo en el Print";
            Task3.color = Color.red;
            Task4.text = "Escribe una condicion verdadera en If";
            Task4.color = Color.red;
        }
        if (Pythonchecker.WhichProgram == 5)
        {
            Task1.text = "Crea el bloque Input";
            Task1.color = Color.red;
            Task2.text = "Escribe en el recuadro para definir una variable";
            Task2.color = Color.red;
            Task3.text = "Escribe tu nombre de usuario en el menú de Valorancia";
            Task3.color = Color.red;
            Task4.text = "Inicia sesión y juega";
            Task4.color = Color.red;
        }
        if (Pythonchecker.WhichProgram == 6)
        {
            Task1.text = "Crea un While";
            Task1.color = Color.red;
            Task2.text = "Crea dos Variables";
            Task2.color = Color.red;
            Task3.text = "Rellena el while para que en algún momento se rompa la condición";
            Task3.color = Color.red;
        }
    }
    public void Animation()
    {
        if(Hide == false)
        {
            gameObject.LeanMoveLocal(Close, 0.5f).setEaseOutCirc();
            Hide = true;
            return;
        }
        if (Hide == true)
        {
            gameObject.LeanMoveLocal(Open, 0.5f).setEaseOutCirc();
            Hide = false;
            return;
        }

    }
    private void Update()
    {
        
        if (Referencias.TaskEdit[0] == true)
        {
            Task1.color = Color.green;
            
        }
        if (Referencias.TaskEdit[0] != true)
        {
            Task1.color = Color.red;

        }
        if (Referencias.TaskEdit[1] == true)
        {
            Task2.color = Color.green;
           
        }
        if (Referencias.TaskEdit[1] != true)
        {
            Task2.color = Color.red;

        }
        if (Referencias.TaskEdit[2] == true)
        {
            Task3.color = Color.green;
            
        }
        //if (Referencias.TaskEdit[2] != true)
        //{
        //    Task3.color = Color.red;

        //}
        if (Referencias.TaskEdit[3] == true)
        {
            Task4.color = Color.green;

        }
    }
}
