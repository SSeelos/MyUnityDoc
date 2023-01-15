
using UnityEngine;

public interface IOnUpdate
{
    void OnUpdate();
}
abstract class OnUpdateStrategy : IOnUpdate
{
    public void OnUpdate()
    {
        Debug.Log("Update");
    }
}

