using System.ComponentModel;
using System.Security.Cryptography;
using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class InventorySystem : MonoBehaviour
{
    public bool onInventory = false; //Toggle inventory UI
    

    [SerializeField] private bool cursorLock = true; // Toggle mouse lock
    [SerializeField] private GameObject inventoryUI;

    private void Awake()
    {
        inventoryUI.SetActive(false); // Hides inventory UI on start.
        Cursor.visible = false; //Hides cursor mouse so it only shows on inventory UI.
        Cursor.lockState = CursorLockMode.Locked; //Locks the mouse in the middle of the screen.
    }


    void Update()
    {
        MouseState();
        
        if (Input.GetKeyDown(KeyCode.Tab)) // Pressing Tab toggles inventory.
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
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                if (cursorLock)
                {
                    cursorLock = false;
                    Cursor.visible = false; //Shows cursor mouse cursor.
                    Cursor.lockState = CursorLockMode.Locked; //Locks the mouse in the middle of the screen.
                }
                else
                {
                    cursorLock = true;
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