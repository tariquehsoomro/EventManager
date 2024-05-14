using UnityEngine;

public class SquareObject : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.Listen(EventKeyE.CallAllThreeObjects, Square);
    }

    private void OnDisable()
    {
        EventManager.Unlisten(EventKeyE.CallAllThreeObjects, Square);
    }

    private void Square()
    {
        Debug.Log("Square method called with event key: CallAllThreeObjects");
    }
}
