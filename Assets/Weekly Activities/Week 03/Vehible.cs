using UnityEngine;

/// <summary>
/// Primary script for vehicles in our high-speed, personification of racing game.
/// </summary>
public class Vehible : MonoBehaviour
{
    //variables need:
    // - access modificer
    // - data type
    // - name
    // - value
    // - access-modifier type name value

    [SerializeField] protected string carCharacterName = "Unnamed Car Character"; //Protected helps to access child's monoscript like Boat

    private float AccelerationRate = 30;
    private int wheelCount = 4;

    //Make method to SET our name

    public void SetVehibleName(string newCarCharacterName/*string*/) 
    {
        carCharacterName = newCarCharacterName;
    }
    // Make a method to GET our name
}
