using UnityEngine;

public class OneShotSpawner : _PrefabSpawner<Transform>
{
    private void Awake()
    {
        Instantiate(prefab);
    }
}
