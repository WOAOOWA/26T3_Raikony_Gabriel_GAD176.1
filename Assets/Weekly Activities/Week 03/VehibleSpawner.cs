using UnityEngine;

/// <summary>
/// Will hold a list of all the cars that exist in the race
/// </summary>
public class VehibleSpawner : MonoBehaviour
{
    [SerializeField] private Vehible[] carArray;

    private void Start()
    {
        carArray[0].SetVehibleName("Chick Hicks");
    }
}
