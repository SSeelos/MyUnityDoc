using System.Collections.Generic;
using UnityEngine;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons;
    public Sprite tabIdle;
    public Sprite tabHovered;
    public Sprite tabSelected;
    public TabButton selectedTab;

    public List<GameObject> objectsToSwap;

    public PanelGroup panelGroup;

    public void Subscribe(TabButton tabButton)
    {
        if (tabButtons == null)
            tabButtons = new List<TabButton>();

        tabButtons.Add(tabButton);
    }
    public void OnTabEnter(TabButton button)
    {
        ResetTabs();

        if (selectedTab != null && button == selectedTab)
            return;

        button.background.sprite = tabHovered;
    }
    public void OnTabExit(TabButton button)
    {
        ResetTabs();

        if (selectedTab != null && button == selectedTab)
            return;

        button.background.sprite = tabIdle;
    }
    public void OnTabSelected(TabButton button)
    {
        if (selectedTab != null)
        {
            selectedTab.Deselect();
        }
        selectedTab = button;
        selectedTab.Select();

        ResetTabs();

        button.background.sprite = tabSelected;

        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < objectsToSwap.Count; i++)
        {
            if (i == index)
            {
                objectsToSwap[i].SetActive(true);
            }
            else
            {
                objectsToSwap[i].SetActive(false);
            }
        }

        if (panelGroup != null)
            panelGroup.SetPageIndex(button.transform.GetSiblingIndex());
    }
    public void ResetTabs()
    {
        foreach (TabButton button in tabButtons)
        {
            if (selectedTab != null && button == selectedTab)
                continue;

            button.background.sprite = tabIdle;
        }
    }

}
