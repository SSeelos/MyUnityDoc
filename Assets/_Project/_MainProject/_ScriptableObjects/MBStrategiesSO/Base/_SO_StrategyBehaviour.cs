
using UnityEngine;

public abstract class AScriptableObject : ScriptableObject, IStrategyBehaviour
{
    public virtual void OnAwake()
    {
        throw new System.NotImplementedException();
    }

    public void OnFixedUpdate()
    {
        throw new System.NotImplementedException();
    }

    public void OnStart()
    {
        throw new System.NotImplementedException();
    }

    public void OnUpdate()
    {
        throw new System.NotImplementedException();
    }
}
