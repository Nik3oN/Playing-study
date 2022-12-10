using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
 

public class DescriptionPanel : MouseOnTrigger, IPointerClickHandler
{
    public GameObject ObjectToShow;
    public GameObject CreateButton;
    public GameObject IconOfObject;
    
    private void Start()
    {
        ObjectToShow.SetActive(false);
        CreateButton.SetActive(false);
        IconOfObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ObjectToShow.SetActive(true);
        CreateButton.SetActive(true);
        IconOfObject.SetActive(true);
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ObjectToShow.SetActive(false);
            CreateButton.SetActive(false);
            IconOfObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CreateButton.SetActive(false);
        }
       
    }

}
