using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySystem : MonoBehaviour
{
    public bool onInventory;

    private bool OnInventory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onInventory = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.G))
        {

        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (onInventory)
            {
                onInventory = false;
                
            }
            else
            {
                onInventory = true;
                
            }
        }
    }

    public void toInventory() //toggle inventory //re-usable for toggle systems
    {
        


    }
}

public class InventorySpawner : InventorySystem
{
    [SerializeField] private InventorySystem inventorySystem;
    
}
public class DragDrop : InventorySystem, IPointerDownHandler//Make the mouse(pointer) check if it is pressed.
    ,IBeginDragHandler, IEndDragHandler //Drag Mechanic.
    ,IDragHandler //Gets called every frame, while also shows debug.logs.
    ,IDropHandler //Allows you to drop to squares.
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
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor; //Adding this, it calculates the amount of movement of the mouse
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

