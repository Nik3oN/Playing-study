using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropdownWhile : MonoBehaviour
{
    private Dropdown A;
    void Start()
    {
        A = transform.GetComponent<Dropdown>();
        A.options.Clear();
        A.options.Add(new Dropdown.OptionData() { text = "Variables:" });
        foreach (var item in Referencias2.VariablePrint)
        {

            A.options.Add(new Dropdown.OptionData() { text = item });


        }

    }
    public void Update()
    { 

            //if(A. != Referencias2.VariablePrint)
            A.options.Clear();
            A.options.Add(new Dropdown.OptionData() { text = "Variables:" });
            foreach (var item in Referencias2.VariablePrint)
            {

               A.options.Add(new Dropdown.OptionData() { text = item });


            }
        
    }
}
