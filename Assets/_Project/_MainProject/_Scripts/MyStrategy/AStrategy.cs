using System.Reflection;
using UnityEngine;

public interface IOnAwake
{
    void OnAwake();

}
public interface IOnStart
{
    void OnStart();

}
public interface IOnFixedUpdate
{
    void OnFixedUpdate();
}
public interface ISetGameObject
{
    void SetGameObject(GameObject gameObject);
}
public interface IStrategyBehaviour : IOnAwake, IOnStart, IOnUpdate, IOnFixedUpdate
{

}
public abstract class AStrategy : IStrategyBehaviour
{
    public void OnAwake()
    {
        Debug.Log(MethodBase.GetCurrentMethod().Name);
    }

    public void OnFixedUpdate()
    {
        Debug.Log(MethodBase.GetCurrentMethod().Name);
    }

    public void OnStart()
    {
        Debug.Log(MethodBase.GetCurrentMethod().Name);
    }

    public void OnUpdate()
    {
        Debug.Log(MethodBase.GetCurrentMethod().Name);
    }
}
public class StrategyA : AStrategy
{

}
