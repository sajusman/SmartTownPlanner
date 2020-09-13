using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public const int SLOTS = 6;
    public static List<IInventoryItem> mItems = new List<IInventoryItem>();
    public static List<IInventoryItem> streetItems = new List<IInventoryItem>();
    public static List<IInventoryItem> otherItems = new List<IInventoryItem>();
    public static List<IInventoryItem> allItems = new List<IInventoryItem>();
    public static int Bcounter = 0;
    public static int Scounter = 0;
    public static int Ocounter = 0;

    void Awake()
    {
        UnityEngine.Object[] subListObjects = Resources.LoadAll("Prefabs/Buildings", typeof(GameObject));
        
        foreach (GameObject subListObject in subListObjects)
        {
            GameObject lo = (GameObject)subListObject;
            
            Sprite icon = Resources.Load<Sprite>("Sprites/Buildings/"+lo.name) as Sprite;

            mItems.Add(new IInventoryItem(lo.name, icon, lo));
            allItems.Add(new IInventoryItem(lo.name, icon, lo));
        }
        // Street
        subListObjects = Resources.LoadAll("Prefabs/Streets", typeof(GameObject));

        foreach (GameObject subListObject in subListObjects)
        {
            GameObject lo = (GameObject)subListObject;

            Sprite icon = Resources.Load<Sprite>("Sprites/Streets/" + lo.name) as Sprite;

            streetItems.Add(new IInventoryItem(lo.name, icon, lo));
            allItems.Add(new IInventoryItem(lo.name, icon, lo));
        }

        //Other
        // Street
        subListObjects = Resources.LoadAll("Prefabs/Other", typeof(GameObject));

        foreach (GameObject subListObject in subListObjects)
        {
            GameObject lo = (GameObject)subListObject;

            Sprite icon = Resources.Load<Sprite>("Sprites/Other/" + lo.name) as Sprite;

            otherItems.Add(new IInventoryItem(lo.name, icon, lo));
            allItems.Add(new IInventoryItem(lo.name, icon, lo));
        }

    }
}
