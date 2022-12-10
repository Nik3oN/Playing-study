using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DragPrint : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public static bool MouseOnIf;
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    protected bool IfDrag;
    
    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();

    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {

        if(gameObject.name == "ImageVar")
        {
            Referencias.VarPrinIn = false;
        }

        if (SlotPrint.PrintWithVar != null)
        {
            SlotPrint.PrintWithVar.GetComponent<TMP_InputField>().text = null;
            SlotPrint.PrintWithVar = null;
        }
        gameObject.transform.parent.parent = null;

    }
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        if (gameObject.tag == "PRINT")
        {
            ItemSlot.InIf = false;

        }

        IfDrag = true;
        Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
        eventData.pointerDrag.tag = "Dropdown";

    }
    public void OnDrag(PointerEventData eventData)
    {

        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta;



    }
    public void OnEndDrag(PointerEventData eventData)
    {

        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        IfDrag = false;

    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}

