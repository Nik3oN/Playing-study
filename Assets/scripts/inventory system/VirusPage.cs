using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusPage : MonoBehaviour
{
    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        transform.LeanScale(Vector2.zero, 0.2f).setEaseOutExpo();
    }

}
