using UnityEngine;

public class ItemPickable : MonoBehaviour, IPickable
{
    public ItemSystem itemScriptableObject;

    public void PickItem()
    { 
        Destroy(gameObject);
    }
}
