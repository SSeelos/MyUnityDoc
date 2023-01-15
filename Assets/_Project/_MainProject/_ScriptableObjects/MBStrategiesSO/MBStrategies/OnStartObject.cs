using UnityEngine;

public abstract class _OnStartObject : ScriptableObject, IOnStart
{
    public abstract void OnStart();
}
public class NullStart : _OnStartObject { public override void OnStart() { } }

[CreateAssetMenu(menuName =AssetMenuConstants.MenuName.ScriptableObject_MonoBehaviourStrategy + "/OnStart")]
class OnStartObject : _OnStartObject
{
    public string message = "Start object";
    public override void OnStart()
    {
        Debug.Log("Start object");
    }
}
