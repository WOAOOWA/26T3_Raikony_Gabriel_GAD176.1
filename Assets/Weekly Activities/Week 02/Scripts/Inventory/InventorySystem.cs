using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySystem : MonoBehaviour
{
    public bool onInventory;

    [SerializeField] private bool cursorLock = false;
    [SerializeField] private GameObject inventoryUI;

    private void Awake()
    {
        onInventory = false;
    }


    void Update()
    {
        MouseState();
        
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!onInventory)
            {
                onInventory = true;
                inventoryUI.SetActive(true);
            }
            else
            {
                onInventory = false;
                inventoryUI.SetActive(false);
                
            }
        }
        void MouseState()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                if (!cursorLock)
                {
                    cursorLock = true;
                    Cursor.visible = false; //Hides mouse cursor.
                    Cursor.lockState = CursorLockMode.Locked; //Locks the mouse in the middle of the screen.
                }
                else
                {
                    cursorLock = false;
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }
            }
        } // Pressing G locks mouse.
    }

    public void toInventory() //toggle inventory //re-usable for toggle systems
    {
        


    }
}


public class InventorySpawner : InventorySystem
{
    [SerializeField] private InventorySystem inventorySystem;

}