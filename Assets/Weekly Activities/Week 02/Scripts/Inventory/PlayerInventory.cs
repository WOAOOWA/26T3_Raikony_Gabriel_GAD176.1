using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [Header("General")]
    public List<itemType> inventoryList;
    public int selectedItem;
    public float playerReach = 10;
    [SerializeField] GameObject throwItem_gameobject;

    [Space(20)]
    [Header("Keys")]
    [SerializeField] KeyCode throwItemKey;
    [SerializeField] KeyCode pickItemKey;

    [Space(20)]
    [Header("Item gameobjects")]
    [SerializeField] GameObject oilLamp_item;
    [SerializeField] GameObject jukebox_item;
    [SerializeField] GameObject potion_item;

    [Space(20)]
    [Header("Item prefabs")]
    [SerializeField] GameObject oilLamp_prefab;
    [SerializeField] GameObject jukebox_prefab;
    [SerializeField] GameObject potion_prefab;

    [SerializeField] Camera cam;
    [SerializeField] GameObject pickUpItem_gameobject;


    private Dictionary<itemType, GameObject> itemSetActive = new Dictionary<itemType, GameObject>() { }; //An entire list of gameobjects actives.
    private Dictionary<itemType, GameObject> itemInstantiate = new Dictionary<itemType, GameObject>() { }; //Throwing list.

    private void Start() //Set active in hierarchy.
    {
        itemSetActive.Add(itemType.OilLamp, oilLamp_item);
        itemSetActive.Add(itemType.Jukebox, jukebox_item);
        itemSetActive.Add(itemType.Potion, potion_item);

        itemInstantiate.Add(itemType.OilLamp, oilLamp_prefab);
        itemInstantiate.Add(itemType.Jukebox, jukebox_prefab);
        itemInstantiate.Add(itemType.Potion, potion_prefab);

        NewItemSelected();
    }

    void Update() // Inventory Inputs from 1 to 9.
    {
        //Pick item Up
        Ray ray = cam.ScreenPointToRay(Input.mousePosition); // Raycast for the camera added.
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, playerReach))
        { 
            IPickable item = hitInfo.collider.GetComponent<IPickable>();
            if (item != null)
            {
                pickUpItem_gameobject.SetActive(true);
                if (Input.GetKey(pickItemKey))
                {
                    inventoryList.Add(hitInfo.collider.GetComponent<ItemPickable>().itemScriptableObject.item_type);
                    item.PickItem();
                }

            }
            else
            {
                pickUpItem_gameobject.SetActive(false);
            }
        }
        else
        {
            pickUpItem_gameobject.SetActive(false);
        }
        // Item throw System.
        if (Input.GetKeyDown(throwItemKey) && inventoryList.Count > 1)
        {
            Instantiate(itemInstantiate[inventoryList[selectedItem]], position: throwItem_gameobject.transform.position, new Quaternion());
            inventoryList.RemoveAt(selectedItem);

            if (selectedItem != 0)
            {
                selectedItem -= 1;
            }
            NewItemSelected();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && inventoryList.Count > 0)
        {
            selectedItem = 0;
            NewItemSelected();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && inventoryList.Count > 1)
        {
            selectedItem = 1;
            NewItemSelected();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && inventoryList.Count > 2)
        {
            selectedItem = 2;
            NewItemSelected();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && inventoryList.Count > 3)
        {
            selectedItem = 3;
            NewItemSelected();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && inventoryList.Count > 4)
        {
            selectedItem = 4;
            NewItemSelected();
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) && inventoryList.Count > 5)
        {
            selectedItem = 5;
            NewItemSelected();
        }
        if (Input.GetKeyDown(KeyCode.Alpha7) && inventoryList.Count > 6)
        {
            selectedItem = 6;
            NewItemSelected();
        }
        if (Input.GetKeyDown(KeyCode.Alpha8) && inventoryList.Count > 7)
        {
            selectedItem = 7;
            NewItemSelected();
        }
        if (Input.GetKeyDown(KeyCode.Alpha9) && inventoryList.Count > 8)
        {
            selectedItem = 8;
            NewItemSelected();
        }
    }

    private void NewItemSelected() //Hides all items.
    {
        oilLamp_item.SetActive(false);
        jukebox_item.SetActive(false);
        potion_item.SetActive(false);

        GameObject selectedItemGameobject = itemSetActive[inventoryList[selectedItem]]; //Shows the gameObject in game.
        selectedItemGameobject.SetActive(true);

    }
}
public interface IPickable
{
    void PickItem();
}
