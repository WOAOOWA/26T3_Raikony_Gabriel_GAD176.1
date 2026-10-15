using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour, ICollectable
{
    public void Collect()
    {
        // collect shi
        //the coin disappears
        Debug.Log("Collected.");
        Destroy(gameObject);
    }
    
}
