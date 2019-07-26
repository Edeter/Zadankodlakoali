using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
  
    [SerializeField] FieldSelection fieldSelection;

    bool clicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    Keyboard();
       
    }

    void Keyboard()
    { if (Input.anyKeyDown)
    {
        fieldSelection.Movepoint(new Vector3(Input.GetAxisRaw("KeyboardX"),Input.GetAxisRaw("KeyboardY"),0));
    }
         if (Input.GetButtonDown("Jump"))
        {
            fieldSelection.Click();
        }
    }


}
