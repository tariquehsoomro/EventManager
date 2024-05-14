using UnityEngine;

public class CircleObject : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.Listen(EventKeyE.CallAllThreeObjects, Circle);
    }

    private void OnDisable()
    {
        EventManager.Unlisten(EventKeyE.CallAllThreeObjects, Circle);
    }

    private void Circle()
    {
        Debug.Log("Circle method called with event key: CallAllThreeObjects");
    }
}
