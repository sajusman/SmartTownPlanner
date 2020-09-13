using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onEditPlan : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject newPlan;
    public GameObject otherMenus;
    public GameObject editPlanMenu;

    public void SetActiveEditPlan()
    {
        mainMenu.SetActive(false);
        otherMenus.SetActive(true);
        newPlan.SetActive(false);
        editPlanMenu.SetActive(true);
    }
}
