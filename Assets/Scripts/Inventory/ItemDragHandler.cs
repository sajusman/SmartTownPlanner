using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragHandler : MonoBehaviour,IDragHandler,IEndDragHandler
{
    public static GameObject itemOnDrag = null;
    public void OnDrag(PointerEventData eventData)
    {
        if (this.GetComponent<SlotController>().item != null)
        {
            SlotController temp = this.GetComponent<SlotController>();
            itemOnDrag = temp.item.ItemPrefab;
            transform.position = Input.mousePosition;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
