﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickInput : MonoBehaviour
{
    [SerializeField] FieldSelection fieldSelection;
    bool clicked = false;
    void Start() {

    }
    void Update()
    {  
        
         Joy();

    }

        void Joy()
    {
         if (Input.GetButtonDown("Jump"))
        {
            fieldSelection.Click();
        }
            if (clicked)
            {
                if ((Mathf.RoundToInt(Input.GetAxisRaw("Joy1X"))==0)&&(Mathf.RoundToInt(Input.GetAxisRaw("Joy1Y"))==0))
                {
                    clicked = false;
                }
            }

        
            if (clicked==false)
            {
             if ((Mathf.RoundToInt(Input.GetAxisRaw("Joy1X"))!=0)||(Mathf.RoundToInt(Input.GetAxisRaw("Joy1Y"))!=0))
                {
                    fieldSelection.Movepoint(new Vector3(Mathf.RoundToInt(Input.GetAxisRaw("Joy1X")),Mathf.RoundToInt(Input.GetAxisRaw("Joy1Y")),0));
                clicked = true;   
                }
                 
            }
        
    
    }
}
