using UnityEngine;

public abstract class _OnAwakeObject : ScriptableObject, IOnAwake
{
    public abstract void OnAwake();
}
public class NullAwake : _OnAwakeObject { public override void OnAwake() { } }

[CreateAssetMenu(menuName = AssetMenuConstants.MenuName.ScriptableObject_MonoBehaviourStrategy + "/OnAwake")]
class OnAwakeObject : _OnAwakeObject
{
    public string message = "Awake object";
    public override void OnAwake()
    {
        Debug.Log(message);
    }
}

