using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{

    public List<TabButton> tabButtons;
    public Sprite tabIdle;
    public Sprite tabHover;
    public Sprite tabActive;

    public void Subscribe(TabButton button)
    {
        button.background.sprite = tabIdle;
        if (tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }

        tabButtons.Add(button);
    }

    public void OnTabEnter(TabButton button)
    {
        ResetTabs();
        button.background.sprite = tabHover;
        Debug.Log("You hovered");
    }

    public void OnTabExit(TabButton button)
    {
        ResetTabs();
        Debug.Log("You exited");
    }

    public void OnTabSelected(TabButton button)
    {
        ResetTabs();
        button.background.sprite = tabActive;
        Debug.Log("You clicked");
    }

    public void ResetTabs()
    {
        foreach(TabButton button in tabButtons)
        {
            button.background.sprite = tabIdle;
        }
    }

}
