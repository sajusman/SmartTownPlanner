using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject newPlan;
    public GameObject otherMenus;
    public GameObject editPlanMenu;

    public void goBackToMainFromNewPlan()
    {
        otherMenus.SetActive(false);
        newPlan.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void goBackToMainFromEditPlan()
    {
        otherMenus.SetActive(false);
        editPlanMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
