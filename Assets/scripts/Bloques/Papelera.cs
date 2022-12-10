using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Papelera : MonoBehaviour, IDropHandler
{

    protected GameObject InIfAction;
    public static bool InIf;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (gameObject.tag == "Papelera")
            {
                InIfAction = eventData.pointerDrag;
                if (eventData.pointerDrag.tag == "PRINT")
                {
                    InIfAction.tag = "Delete";
                    Print.Detroys = 1;
                    
                    
                }
                    
                     
                    
                
            }



        }
    }
}
