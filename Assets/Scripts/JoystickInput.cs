using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickInput : MonoBehaviour
{
    [SerializeField] FieldSelection fieldSelection;
    bool clicked = false;
    [SerializeField] string ControllerName = "Joy1";
    void Start() {

    }
    void Update()
    {  
        
         Joy();

    }

        void Joy()
    {
         if (Input.GetButtonDown(ControllerName + "Jump"))
        {
            fieldSelection.Click();
        }
            if (clicked)
            {
                if ((Mathf.RoundToInt(Input.GetAxisRaw(ControllerName + "X"))==0)&&(Mathf.RoundToInt(Input.GetAxisRaw(ControllerName + "Y"))==0))
                {
                    clicked = false;
                }
            }

        
            if (clicked==false)
            {
             if ((Mathf.RoundToInt(Input.GetAxisRaw(ControllerName + "X"))!=0)||(Mathf.RoundToInt(Input.GetAxisRaw(ControllerName + "Y"))!=0))
                {
                    fieldSelection.Movepoint(new Vector3(Mathf.RoundToInt(Input.GetAxisRaw(ControllerName + "X")),Mathf.RoundToInt(Input.GetAxisRaw(ControllerName + "Y")),0));
                clicked = true;   
                }
                 
            }
        
    
    }
}
