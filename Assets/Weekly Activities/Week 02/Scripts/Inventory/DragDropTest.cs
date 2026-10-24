using UnityEngine;
using UnityEngine.EventSystems;
/// <summary>
/// This Script is only used, because I commit a huge mystake somewhere and only this script shows that DraNDrop still working.
/// </summary>
public class DragDropTest : InventorySystem, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pressed");
    }
}

