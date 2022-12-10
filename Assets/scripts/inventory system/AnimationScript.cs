using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    private void Start()
    {
        transform.localScale = Vector2.zero;
    }

    public void Open()
    {
        transform.LeanScale(Vector2.one, 0.8f).setEaseOutExpo();
        
    }

    public void OnVirusClick()
    {
        transform.LeanSetLocalPosX(0.5f);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            transform.LeanScale(Vector2.zero, 1f).setEaseOutExpo();
        }
            
    }
}
