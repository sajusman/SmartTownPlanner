using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToNewPlan : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject newPlan;
    public GameObject editPlan;
    public GameObject otherMenus;

    public void SetActiveNewPlan()
    {
        mainMenu.SetActive(false);
        otherMenus.SetActive(true);
        newPlan.SetActive(true);
        editPlan.SetActive(false);
    }
}
