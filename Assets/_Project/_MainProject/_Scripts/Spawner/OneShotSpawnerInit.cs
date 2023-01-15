public class OneShotSpawnerInit : _PrefabSpawner<ObjectToFind>
{
    private void Awake()
    {
        if (prefab == null)
            return;

        var instance = Instantiate(prefab);

        if (instance.GetComponent<FindObject>() is FindObject findObject)
            instance.Init(findObject);
    }
}
