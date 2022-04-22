using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit_button : MonoBehaviour
{
    void OnMouseDown(){
        if(Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }
}
