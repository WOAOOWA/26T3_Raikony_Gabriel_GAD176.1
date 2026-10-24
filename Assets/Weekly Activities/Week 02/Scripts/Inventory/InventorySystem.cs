using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] public GameObject bgInv;
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
    ,IBeginDragHandler, IEndDragHandler //Drag Mechanic
    ,IDragHandler //Gets called every frame, while also shows debug.logs
{
    public void OnBeginDrag(PointerEventData eventdata)
    {
        Debug.Log("Start Drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("MOVING");
    }
    public void OnEndDrag(PointerEventData eventdata)
    {
        Debug.Log("End Drag");
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pressed");
    }
    private void update()
    {

    }
}
