using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class VirusController : MonoBehaviour /*IDragHandler*/ /*IPointerClickHandler*/
{

    [SerializeField]
    public VirusPage virusUI;

    public int VirusSize = 10;
    private void Start()
    {
        
    }

    private bool Drag = false;
    private RectTransform rectTransform;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    //public void OnDrag(PointerEventData eventData)
    //{
        
    //    Drag = true;
    //    rectTransform.anchoredPosition += eventData.delta;

    //}

    //public void Update()
    //{
    //    if (Input.GetKey(KeyCode.Escape))
    //    {
    //            virusUI.Hide();
    //    }
    //}

    //public void OnPointerClick(PointerEventData eventData)
    //{
    //    virusUI.Show();
    //}
}
