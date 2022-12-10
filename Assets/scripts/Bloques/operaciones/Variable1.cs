using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Variable1 : MonoBehaviour, IDropHandler
{
    public static List<int> Var1 = new();
    public void OnDrop(PointerEventData eventData)
    {


        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.tag == "Dropdown")
            {

                eventData.pointerDrag.transform.parent.parent = gameObject.transform.parent;
                eventData.pointerDrag.transform.position = gameObject.transform.position;

                eventData.pointerDrag.LeanScale(new Vector3(0.8f, 0.8f), 0.1f).setEaseInCubic();
                eventData.pointerDrag.tag = "Variable1";

            }
            else
            {

                eventData.pointerDrag.transform.position = gameObject.transform.position;
                eventData.pointerDrag.LeanScale(new Vector3(1f, 1f), 0.1f).setEaseInCubic();

            }

        }
    }
}
