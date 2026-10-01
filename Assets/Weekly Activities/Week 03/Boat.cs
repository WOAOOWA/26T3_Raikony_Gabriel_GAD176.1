using UnityEngine;

public class Boat : Vehible
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("This vehibles name is " + carCharacterName);
    }
    private void Update()
    {
        // player input
        // When player holds UP arrow (accelerate)
        // Add physics forward to accelerate vehible
        // using the "accelerationRate" variable
    }
}
