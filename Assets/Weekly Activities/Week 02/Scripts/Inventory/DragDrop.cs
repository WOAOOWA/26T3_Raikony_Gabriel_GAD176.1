using UnityEngine;
using UnityEngine.EventSystems; //Use that for events.

public class DragNDrop : MonoBehaviour,IPointerDownHandler //Make the mouse(pointer) check if it is pressed.
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pressed");
    }
}