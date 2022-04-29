using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_manager : MonoBehaviour
{
    public void loadMainMenuScene(){
        SceneManager.LoadScene("main_menu");
    }

    public void loadMainGameScene(){
        SceneManager.LoadScene("main_game");
    }

    public void loadSettingsScene(){
        SceneManager.LoadScene("settings");
    }
}
