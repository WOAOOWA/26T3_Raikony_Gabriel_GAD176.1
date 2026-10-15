using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] private GameObject bgInv;

    private bool OnInventory = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bgInv);
        }
    }

}
