using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IInventoryItem
{
    public string name { get; set; }
    public Sprite Image { get; set; }
    public GameObject ItemPrefab { get; set; }
    
    public IInventoryItem(string name , Sprite Image, GameObject ItemPrefab)
    {
        this.name = name;
        this.Image = Image;
        this.ItemPrefab = ItemPrefab;
    }

    
}
