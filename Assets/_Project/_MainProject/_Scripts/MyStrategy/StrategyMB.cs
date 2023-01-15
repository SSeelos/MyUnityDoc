using UnityEngine;

public class StrategyMB : MonoBehaviour
{
    public _OnAwakeObject onAwakeObject;
    public _OnStartObject onStartObject;
    public _OnUpdateObject onUpdateObject;
    public _OnFixedUpdateObject onFixedUpdateObject;

    //public IOnAwake onAwake;
    //public IStrategyBehaviour strategyBehaviour;

    private void Awake()
    {
        if (onAwakeObject == null) onAwakeObject = new NullAwake();
        if (onStartObject == null) onStartObject = new NullStart();
        if (onUpdateObject == null) onUpdateObject = new NullUpdate();
        if (onFixedUpdateObject == null)
            onFixedUpdateObject = new NullFixedUpdate();
        else onFixedUpdateObject.SetGameObject(this.gameObject);

        onAwakeObject.OnAwake();

        //strategyBehaviour = new StrategyA();
        //strategyBehaviour.OnAwake();


    }
    private void Start()
    {
        onStartObject.OnStart();
    }
    private void Update()
    {
        onUpdateObject.OnUpdate();
    }
    private void FixedUpdate()
    {
        onFixedUpdateObject.OnFixedUpdate();
    }
}
