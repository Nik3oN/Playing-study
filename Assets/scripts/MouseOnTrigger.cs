using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOnTrigger : MonoBehaviour
{
    protected bool IsMousOnButton;

    private void Awake()
    {
        IsMousOnButton = true;
    }
}
