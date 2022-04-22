using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class base_button : MonoBehaviour
{

    public virtual void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))  {
            Debug.Log("base button pressed!");
        }
    }
}
