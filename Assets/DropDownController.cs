using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownController : MonoBehaviour
{
    public Dropdown groupSelector;
    public static string selectedGroup = "Buildings"; //Default
    public List<Image> slots;
    public List<SlotController> slotData;
    void Start()
    {
        for(int i=0; i<6; i++)
        {
            
            slotData.Add(slots[i].GetComponent<SlotController>());
    
        }
        groupSelector.onValueChanged.AddListener(delegate {
            DropdownValueChanged(groupSelector);
        });
    }

    void DropdownValueChanged(Dropdown change)
    {
        int i=0;
        if(change.value == 0) //Buildings
        {
            Inventory.Bcounter = 0;
            selectedGroup = "Buildings";
            for(i=0; i<6 && Inventory.Bcounter < Inventory.mItems.Count; i++)
            {
                slotData[i].item = Inventory.mItems[Inventory.Bcounter];
                slotData[i].img.sprite = Inventory.mItems[Inventory.Bcounter].Image;
                Inventory.Bcounter++;
            }
        }
        else if(change.value == 1) //Streets
        {
            Inventory.Scounter = 0;
            selectedGroup = "Streets";
            for (i = 0; i < 6 && Inventory.Scounter<Inventory.streetItems.Count; i++)
            {
                slotData[i].item = Inventory.streetItems[Inventory.Scounter];
                slotData[i].img.sprite = Inventory.streetItems[Inventory.Scounter].Image;
                Inventory.Scounter++;
            }
        }
        else if (change.value == 2) //Others
        {
            Inventory.Ocounter = 0;
            selectedGroup = "Other";
            for (i = 0; i < 6 && Inventory.Ocounter < Inventory.otherItems.Count; i++)
            {
                slotData[i].item = Inventory.otherItems[Inventory.Ocounter];
                slotData[i].img.sprite = Inventory.otherItems[Inventory.Ocounter].Image;
                Inventory.Ocounter++;
            }
        }
        if (i < 6)
        {
            for(int j=i; j<6; j++)
            {
                slotData[j].item = null;
                slotData[j].img.sprite = Resources.Load<Sprite>("Textures/Right");
            }
        }

    }
}
