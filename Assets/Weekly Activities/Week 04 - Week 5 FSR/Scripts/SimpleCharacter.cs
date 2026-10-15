using UnityEngine;

/// <summary>
/// Attach this to a gameobject with a collider to allow it to move around with WSAD (or arrows) input.
/// </summary>
public class SimpleCharacter : MonoBehaviour
{
    [System.NonSerialized] private float moveSpeedInUnitsPerSecond = 8;

    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeedInUnitsPerSecond * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        //if hit a coin, collect it
        if(other.GetComponent<Coin>() != null)
        {
            other.GetComponent<Coin>().Collect();
        }
    }
    
}
