using UnityEngine;

public class MyTest : MonoBehaviour
{
    public MyMonoBehaviour behaviour;

    [ContextMenu("UpdateField")]
    public void UpdateField()
    {
        behaviour.SetField(1);
        print(behaviour.GetField());
    }
}


