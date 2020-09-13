using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoBack : MonoBehaviour
{
    public List<Image> slots;


    public void goBack()
    {
        // Total - pichlay walay page k 6 - jitne is page pe hain = counter position
        if(DropDownController.selectedGroup == "Buildings")
        {

            int z = (Inventory.Bcounter % 6 == 0) ? 6 : Inventory.Bcounter%6;
            int k = Inventory.Bcounter - 6 - z;
            if (k >= 0)
            {
                Inventory.Bcounter = k;
                for (int i = 0; i < 6; i++)
                {
                    slots[i].GetComponent<SlotController>().item = Inventory.mItems[Inventory.Bcounter];
                    slots[i].sprite = Inventory.mItems[Inventory.Bcounter].Image;
                    Inventory.Bcounter++;
                }
            }
        }
        else if(DropDownController.selectedGroup == "Streets")
        {
            int z = (Inventory.Scounter % 6 == 0) ? 6 : Inventory.Scounter % 6;
            int k = Inventory.Scounter - 6 - z;
            
            if (k >= 0)
            {
                Inventory.Scounter = k;
                for (int i = 0; i < 6; i++)
                {
                    slots[i].GetComponent<SlotController>().item = Inventory.streetItems[Inventory.Scounter];
                    slots[i].sprite = Inventory.streetItems[Inventory.Scounter].Image;
                    Inventory.Scounter++;
                }
            }
        }
        else if (DropDownController.selectedGroup == "Other")
        {
            int z = (Inventory.Ocounter % 6 == 0) ? 6 : Inventory.Ocounter % 6;
            int k = Inventory.Ocounter - 6 - z;
            if (k >= 0)
            {
                Inventory.Ocounter = k;
                for (int i = 0; i < 6; i++)
                {
                    slots[i].GetComponent<SlotController>().item = Inventory.otherItems[Inventory.Ocounter];
                    slots[i].sprite = Inventory.otherItems[Inventory.Ocounter].Image;
                    Inventory.Ocounter++;
                }
            }
        }
    }
}
