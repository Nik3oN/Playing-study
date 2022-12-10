using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class VariableSlot : MonoBehaviour, IDropHandler

{
    public static GameObject PrintWithVar;
    private bool Slot = true;
    public void OnDrop(PointerEventData eventData)
    {
   

        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            if (/*gameObject.tag == "IfSlot" &&*/ eventData.pointerDrag.tag == "VariablePrint")
            {
                PrintWithVar = gameObject;
                Debug.Log(gameObject.name);
                eventData.pointerDrag.transform.parent = gameObject.transform.parent.parent;
                eventData.pointerDrag.transform.position = gameObject.transform.position;
                eventData.pointerDrag.LeanScale(new Vector3(0.8f, 0.8f), 0.1f).setEaseInCubic();
                Referencias.VarPrinIn = true;
                Debug.Log("conected");
            }
            else
            {
                
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.LeanScale(new Vector3(1f, 1f), 0.1f).setEaseInCubic();

            }
            Slot = false;
        }

    }
}
