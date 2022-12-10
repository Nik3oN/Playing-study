using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.EventSystems;

public class VirusCodepart : MonoBehaviour
{
    [SerializeField]
    public Image codeImage;
    [SerializeField]
    private TMP_Text quantityTxt;

    [SerializeField]
    private Image borderImage;

    public event Action<VirusCodepart> OnCodeClicked, OnCodeDroppedOn, OnCodeBeginDrag, OnCodeEndDrag, OnRightMouseBtnClick;

    private bool empty = true;


    public void Awake()
    {
        ResetData();
        Deselect();
    }

    public void Deselect()
    {
        borderImage.enabled = false;
    }

    public void ResetData()
    {
        this.codeImage.gameObject.SetActive(false);
        empty = true; 
    }

    public void SetData(Sprite sprite, int quantity)
    {
        this.codeImage.gameObject.SetActive(true);
        this.codeImage.sprite = sprite;
        this.quantityTxt.text = quantity + "";
        empty = false;
    }
    public void Select()
    {
        borderImage.enabled = true;
    }

    public void OnBeginDrag()
    {
        if (empty)
            return;
        OnCodeBeginDrag?.Invoke(this);
    }
    public void OnDrop()
    {
        OnCodeDroppedOn?.Invoke(this);
    }

    public void OnEndDrag()
    {
        OnCodeEndDrag?.Invoke(this);
    }

    public void OnPointerClick(BaseEventData data)
    {
        if (empty)
            return;

        PointerEventData pointerData = (PointerEventData)data;
        if (pointerData.button == PointerEventData.InputButton.Right)
        {
            OnRightMouseBtnClick?.Invoke(this);
        }
        else
        {
            OnCodeClicked?.Invoke(this);
        }
    }
}



