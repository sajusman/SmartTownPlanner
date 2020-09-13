using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoNext : MonoBehaviour
{
    public List<Image> slots;

    public void goNext()
    {
        int i=0;
        if(DropDownController.selectedGroup == "Buildings")
        {
            if (Inventory.Bcounter < Inventory.mItems.Count)
            {
                for (i = 0; i < 6 && (Inventory.Bcounter < Inventory.mItems.Count); i++)
                {
                    slots[i].GetComponent<SlotController>().item = Inventory.mItems[Inventory.Bcounter];
                    slots[i].sprite = Inventory.mItems[Inventory.Bcounter].Image;
                    Inventory.Bcounter++;
                }

                for (int j = i; j < 6; j++)
                {
                    slots[j].GetComponent<SlotController>().item = null;
                    slots[j].sprite = Resources.Load<Sprite>("Textures/Right");
                }

            }
        }
        else if(DropDownController.selectedGroup == "Streets")
        {
            if (Inventory.Scounter < Inventory.streetItems.Count)
            {
                for (i = 0; i < 6 && (Inventory.Scounter < Inventory.streetItems.Count); i++)
                {
                    slots[i].GetComponent<SlotController>().item = Inventory.streetItems[Inventory.Scounter];
                    slots[i].sprite = Inventory.streetItems[Inventory.Scounter].Image;
                    Inventory.Scounter++;
                }

                for (int j = i; j < 6; j++)
                {
                    slots[j].GetComponent<SlotController>().item = null;
                    slots[j].sprite = Resources.Load<Sprite>("Textures/Right");
                }
            }
        }
        else if (DropDownController.selectedGroup == "Other")
        {
            if (Inventory.Ocounter < Inventory.otherItems.Count)
            {
                for (i = 0; i < 6 && (Inventory.Ocounter < Inventory.otherItems.Count); i++)
                {
                    slots[i].GetComponent<SlotController>().item = Inventory.otherItems[Inventory.Ocounter];
                    slots[i].sprite = Inventory.otherItems[Inventory.Ocounter].Image;
                    Inventory.Ocounter++;
                }
                for (int j = i; j < 6; j++)
                {
                    slots[j].GetComponent<SlotController>().item = null;
                    slots[j].sprite = Resources.Load<Sprite>("Textures/Right");
                }
            }
        }

        //Fill empty slots
       

    }
}
