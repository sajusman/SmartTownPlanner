using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotController : MonoBehaviour
{
    public IInventoryItem item;
    public Image img;
    private void Start()
    {

        if (Inventory.Bcounter < 6)
        {
            item = Inventory.mItems[Inventory.Bcounter];
            //This objects sprite to Items Sprite
            img.sprite = item.Image;
            Inventory.Bcounter++;
        }
    }
}
