
using UnityEngine;

abstract class OnAwakeStrategy : IOnAwake
{
    public void OnAwake()
    {
        Debug.Log("Awake");
    }
}

