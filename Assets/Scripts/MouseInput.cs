using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
Vector3 Mouselastpos;
    [SerializeField] FieldSelection fieldSelection;
 
    // Start is called before the first frame update
    void Start()
    {Mouselastpos = Input.mousePosition;
        
    }

    // Update is called once per frame
    void Update()
    {
        Mousepos();

        if (Input.GetMouseButtonDown(0))
        {
            fieldSelection.Click();
        }
    }
    void Mousepos()
    {
       
        if (Mouselastpos!=Input.mousePosition)
        {
         Vector3 tak = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        fieldSelection.Pointindex.x = Mathf.RoundToInt(tak.x/3) +1;
        fieldSelection.Pointindex.y = Mathf.RoundToInt(tak.y/3) +1;
        

        }
        

        Mouselastpos = Input.mousePosition;
        //Click();
    }
}
