using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab3Manipulator : MouseManipulator
{

    public Lab3Manipulator()
    {

    }

    protected override void RegisterCallbacksOnTarget()
    {
        target.RegisterCallback<MouseEnterEvent>(OnMouseEnter);
        target.RegisterCallback<MouseLeaveEvent>(OnMouseLeave);

    }

    protected override void UnregisterCallbacksFromTarget()
    {
        target.UnregisterCallback<MouseEnterEvent>(OnMouseEnter);
        target.UnregisterCallback<MouseLeaveEvent>(OnMouseLeave);
    }


    void OnMouseEnter(MouseEnterEvent mev)
    {
        Debug.Log(target.name + ": Click en elemento");

        
        target.style.borderBottomColor = Color.white;   
        target.style.borderTopColor = Color.white;   
        target.style.borderLeftColor = Color.white;   
        target.style.borderRightColor  = Color.white;   


        target.style.borderTopWidth = 5;
        target.style.borderBottomWidth = 5;
        target.style.borderRightWidth = 5;
        target.style.borderLeftWidth = 5;


        mev.StopPropagation();
        

    }
    void OnMouseLeave(MouseLeaveEvent mlv)
    {
        Debug.Log(target.name + ": fuera");

      
        target.style.borderTopWidth = 0;
        target.style.borderBottomWidth = 0;
        target.style.borderRightWidth = 0;
        target.style.borderLeftWidth = 0;

        mlv.StopPropagation();
        
    }
  
    
}
