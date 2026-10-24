using UnityEngine;
using UnityEngine.EventSystems;
/// <summary>
/// This Script is only used, because I commit a huge mystake somewhere and only this script shows that DraNDrop still working.
/// </summary>
public class DragDrop : InventorySystem, IPointerDownHandler//Make the mouse(pointer) check if it is pressed.
    , IBeginDragHandler, IEndDragHandler //Drag Mechanic.
    , IDragHandler //Gets called every frame, while also shows debug.logs.
    , IDropHandler //Allows you to drop to squares.
{
    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;


    private void Awake() //awake is even faster than start, as it begin first
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pressed");
    }

    public void OnBeginDrag(PointerEventData eventdata)
    {
        Debug.Log("Start Drag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("MOVING");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;// / canvas.scaleFactor; //Adding this, it calculates the amount of movement of the mouse
    }
    public void OnEndDrag(PointerEventData eventdata)
    {
        Debug.Log("End Drag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}

