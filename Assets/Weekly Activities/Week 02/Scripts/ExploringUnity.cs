using UnityEngine;
using UnityEngine.Events;
public class animal
{
    public bool bark = false;
}
public class ExploringUnity : MonoBehaviour
{
    //Exploring Unity
    bool isBallin = true;
    public static UnityEvent OnSpacebarPressed = new UnityEvent();
}
