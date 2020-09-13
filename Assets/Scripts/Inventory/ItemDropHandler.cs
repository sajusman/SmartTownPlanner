using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDropHandler : MonoBehaviour,IDropHandler
{
    public static List<ItemData> toSaveItems = new List<ItemData>();

    public void OnDrop(PointerEventData eventData)
    {
        RectTransform invPanel = transform as RectTransform;

        if (!RectTransformUtility.RectangleContainsScreenPoint(invPanel, Input.mousePosition))
        {
            RaycastHit hit = new RaycastHit();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         

            GameObject instance = ItemDragHandler.itemOnDrag;
            
            if (instance != null && Physics.Raycast(ray,out hit,500))
            {
                Instantiate(instance, hit.point, Quaternion.identity);
                //Save the item to cache:
                ItemData data = new ItemData(hit.point, instance.name);
                toSaveItems.Add(data);
            }
        }
    }

    public static void loadItem(GameObject itemPrefab,Vector3 position)
    {
        Instantiate(itemPrefab, position, Quaternion.identity);
    }
}
