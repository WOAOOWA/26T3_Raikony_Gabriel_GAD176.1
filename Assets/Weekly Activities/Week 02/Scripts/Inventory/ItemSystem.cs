using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Object Script/Item")]

public class ItemSystem : MonoBehaviour
{
    [Header("Properties")]
    public float potionDuration;
    public float lightSize;
    public itemType item_type;
    public Sprite item_sprite;

}
public enum itemType { OilLamp, Jukebox, Potion };
