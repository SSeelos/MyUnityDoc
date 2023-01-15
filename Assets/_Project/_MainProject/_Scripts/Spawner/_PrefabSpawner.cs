using UnityEngine;

public class _PrefabSpawner<T> : MonoBehaviour where T : Component
{
    [SerializeField]
    protected T prefab;

}
