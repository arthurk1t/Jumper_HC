using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class PanelView : MonoBehaviour
{
    public Action ButtonPressed;

    private void Awake()
    {
        
    }

    void Update()
    {
        
    }

    public void OnButtonPressed() 
    {
        ButtonPressed?.Invoke();
    }
}   
