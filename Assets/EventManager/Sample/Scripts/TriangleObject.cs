using UnityEngine;

public class TriangleObject : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.Listen(EventKeyE.CallAllThreeObjects, Triangle);
    }

    private void OnDisable()
    {
        EventManager.Unlisten(EventKeyE.CallAllThreeObjects, Triangle);
    }

    private void Triangle()
    {
        Debug.Log("Triangle method called with event key: CallAllThreeObjects");
    }
}
