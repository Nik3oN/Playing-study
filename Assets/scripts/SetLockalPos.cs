using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLockalPos : MonoBehaviour
{
    private Vector2 InitalPos;
    private Vector3 Scale;
    private void Start()
    {
        InitalPos = gameObject.transform.localPosition;
        Scale = gameObject.transform.localScale;
    }
    void Update()
    {
        gameObject.transform.localPosition = InitalPos;
        gameObject.transform.localScale = Scale;
    }
}
