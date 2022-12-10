using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
public class SlotPrint : MonoBehaviour, IDropHandler
{
    public static GameObject PrintWithVar;
    private bool PrintWithOp;
    private void Update()
    {
        if(PrintWithOp == true && PorfaOp.AllDoneOp == true)
        {
            gameObject.GetComponent<TMP_InputField>().text = PorfaOp.Vartot;
            
        }
    }
    public void OnDrop(PointerEventData eventData)
    {
 

        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.tag == "Dropdown")
            {
                PrintWithVar = gameObject;
                eventData.pointerDrag.transform.parent.parent = gameObject.transform.parent;
                eventData.pointerDrag.transform.position = gameObject.transform.position;
                
                eventData.pointerDrag.LeanScale(new Vector3(0.8f, 0.8f), 0.1f).setEaseInCubic();
                eventData.pointerDrag.tag = "VariablePrint";
                Referencias.VarPrinIn = true;

            }
            if(eventData.pointerDrag.name == "Operaciones")
            {
                if(Pythonchecker.WhichProgram == 3)
                {
                    Referencias.TaskEdit[3] = true;
                }
                PrintWithOp = true;
                eventData.pointerDrag.transform.parent.parent.parent = gameObject.transform.parent;
                eventData.pointerDrag.transform.position = gameObject.transform.position;
                eventData.pointerDrag.LeanScale(new Vector3(0.8f, 0.8f), 0.15f).setEaseInCubic();
            }
            else
            {
                PrintWithOp = false;
                if (Pythonchecker.WhichProgram == 3)
                {
                    Referencias.TaskEdit[3] = false;
                }
                eventData.pointerDrag.transform.position = gameObject.transform.position;
                eventData.pointerDrag.LeanScale(new Vector3(1f, 1f), 0.1f).setEaseInCubic();

            }
            
        }

    }
}
