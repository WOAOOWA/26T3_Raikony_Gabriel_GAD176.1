using UnityEngine;

public class UnityEventSubscriber : MonoBehaviour
{
    private void OnEnable()
    {
        //Subscribe to events we want to happen
        if (ExploringUnity.OnSpacebarPressed != null)
        {
            ExploringUnity.OnSpacebarPressed.AddListener(PrintMessage); // add a listener // You can also use OnSpacebarPressed += PrintMessage ig???
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ExploringUnity.OnSpacebarPressed?.Invoke(); //if something is listening = invoke
        }
    }
    private void OnDisable()
    {
        //Unsubscribe to all events we want to happen on enable
        if (ExploringUnity.OnSpacebarPressed != null)
        {
            ExploringUnity.OnSpacebarPressed.RemoveListener(PrintMessage);
        }
    }
    private void PrintMessage()
    {

        Debug.Log("Les go");
    }
}
