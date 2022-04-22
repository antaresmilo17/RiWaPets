using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_button : base_button
{
    private scene_manager sceneManager;

    void Start(){
        sceneManager = new scene_manager();
    }

    public override void OnMouseDown(){
        if(Input.GetMouseButtonDown(0))
        {
            sceneManager.loadMainGameScene();
        }
    }
}
