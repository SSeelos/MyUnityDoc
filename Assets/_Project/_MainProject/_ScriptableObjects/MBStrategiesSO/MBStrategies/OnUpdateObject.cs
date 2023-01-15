using UnityEngine;

public interface IGetVector
{
    Vector3 vector { get; }
}

public abstract class _OnUpdateObject : ScriptableObject, IOnUpdate, IGetVector
{
    public Vector3 vector { get; protected set; }
    public abstract void OnUpdate();
}
public class NullUpdate : _OnUpdateObject
{
    public override void OnUpdate() { vector = Vector3.zero; }
}

[CreateAssetMenu(menuName = AssetMenuConstants.MenuName.ScriptableObject_MonoBehaviourStrategy + "/OnUpdate")]
public class OnUpdateObject : _OnUpdateObject
{
    private InputActions inputActions;
    private void Awake()
    {
        inputActions = new InputActions();
        inputActions.Enable();
    }
    public override void OnUpdate()
    {
        vector = inputActions.GamePlay.Move.ReadValue<Vector2>();
    }
}
