using UnityEngine;

public class CallObjects : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EventManager.Trigger(EventKeyE.CallAllThreeObjects);
        }
    }
}
