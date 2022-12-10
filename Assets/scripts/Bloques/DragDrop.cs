using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
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
        
        if(gameObject == ItemSlot.InIfAction)
        {
            gameObject.transform.parent.parent = null;
        }
        if(gameObject.tag == "Operciones")
        {

        }
     }
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        if (gameObject.tag == "PRINT")
        {
            ItemSlot.InIf = false;

        }
        
        IfDrag = true;
        
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;

    }
    public void OnDrag(PointerEventData eventData)
    {

        
        rectTransform.anchoredPosition  += eventData.delta;



    }
    public void OnEndDrag(PointerEventData eventData)
    {

        
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        IfDrag = false;

    }
            
    public void OnDrop(PointerEventData eventData) 
    { 
        
    }
}
