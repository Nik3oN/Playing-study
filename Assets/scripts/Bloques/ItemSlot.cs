using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ItemSlot : MonoBehaviour, IDropHandler
{
    private GameObject IfTaging;
    public static bool InIf;
    public static GameObject InIfAction;
    public static Vector3 InIfActionPos;
    public static List<string> TrueForPrint = new();
    public static bool Inprint;
    private GameObject ObjDraged;
    //public GameObject[] Actions = { };
    private  bool Slot = true;
    private int i = 0;
    public void OnDrop(PointerEventData eventData)
    {
        //if(eventData.pointerDrag == null)
        //{
        //    Slot = true;
        //}
        //if (Slot == true)
        //{


        Debug.Log(eventData.pointerDrag.name);
        if (eventData.pointerDrag != null)
        {
            ObjDraged = eventData.pointerDrag;
            if(gameObject.tag == "Papelera")
            {
                if (eventData.pointerDrag.tag == "PRINT")
                {
                    Destroy(ObjDraged);
                    Referencias.Printos.RemoveAt(Referencias.PrintObj.IndexOf(ObjDraged));
                    Referencias.PrintObj.RemoveAt(Referencias.PrintObj.IndexOf(ObjDraged));
                    
                }
                
            }
            if (gameObject.tag == "IfSlot" && eventData.pointerDrag.tag == "PRINT")
            {
                InIfAction = eventData.pointerDrag;
                eventData.pointerDrag.transform.parent.parent = gameObject.transform.parent;
                eventData.pointerDrag.transform.position = gameObject.transform.position;
                InIf = true;
                eventData.pointerDrag.LeanScale(new Vector3(0.8f, 0.8f), 0.1f).setEaseInCubic();
                if (Pythonchecker.WhichProgram == 4)
                {
                    Referencias.TaskEdit[1] = true;
                }
            }
            if(gameObject.tag == "IfSlot" && eventData.pointerDrag.name == "Operaciones")
            {
                Inprint = true;
                eventData.pointerDrag.transform.parent.parent.parent = gameObject.transform.parent;
                eventData.pointerDrag.transform.position = gameObject.transform.position;
                eventData.pointerDrag.LeanScale(new Vector3(0.5f, 0.5f), 0.15f).setEaseInCubic();
            }
            else
            {
                if(eventData.pointerDrag.name != "while")
                {
                    eventData.pointerDrag.transform.position = gameObject.transform.position;
                    eventData.pointerDrag.LeanScale(new Vector3(1f, 1f), 0.1f).setEaseInCubic();
                }
                

            }
            Slot = false;
        }
        
    }
    //public void Update()
    //{
    //    if (gameObject.tag == "IfSlot" && InIf == true)
    //    {
    //        InIfAction.GetComponent<RectTransform>().position = gameObject.transform.position;
            
    //    }
        
    //}
  
   
}
