
using System;
using System.Reflection;
using UnityEngine;
public interface ILogger
{
    void ClassLog(Type thisGetType);
    void MethodLog(MethodBase currentMethod);
    void ClassMethodLog(Type thisGetType, MethodBase currentMethod);
}
public class NullLogger : ILogger
{
    public static NullLogger Instance => new NullLogger();

    public void ClassLog(Type thisGetType)
    {
    }

    public void ClassMethodLog(Type thisGetType, MethodBase currentMethod)
    {
    }

    public void MethodLog(MethodBase currentMethod)
    {
    }
}
public class DebugLogger : ILogger
{
    private bool enabled = true;
    public bool Enabled
    {
        set
        {
            enabled = value;
            if (enabled) _instance = new DebugLogger();
            else _instance = new NullLogger();
        }
    }
    private static ILogger _instance = new DebugLogger();
    public static ILogger Instance => _instance;

    public void ClassLog(Type classGetType)
    {
        Debug.Log(classGetType.Name + ", " + MethodBase.GetCurrentMethod().Name);
    }
    public void MethodLog(MethodBase currentMethod)
    {
        Debug.Log(currentMethod.Name);
    }

    public void ClassMethodLog(Type classGetType, MethodBase currentMethod)
    {
        Debug.Log(classGetType.Name + ", " + currentMethod.Name);
    }
    public void ObjectLog(object obj)
    {
        Debug.Log(obj);
    }

}

