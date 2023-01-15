using UnityEngine;


public abstract class _OnFixedUpdateObject : ScriptableObject, IOnFixedUpdate, ISetGameObject
{
    public abstract void OnFixedUpdate();
    protected GameObject GameObject;
    public void SetGameObject(GameObject gameObject)
    {
        this.GameObject = gameObject;
    }
}
public class NullFixedUpdate : _OnFixedUpdateObject { public override void OnFixedUpdate() { } }


[CreateAssetMenu(menuName = AssetMenuConstants.MenuName.ScriptableObject_MonoBehaviourStrategy + "/OnFixedUpdate")]
class OnFixedUpdateObject : _OnFixedUpdateObject
{
    public float speed;
    private Vector3 velocity;
    private Rigidbody2D rigidbody => this.GameObject.GetComponent<Rigidbody2D>();
    private StrategyMB strategy => this.GameObject.GetComponent<StrategyMB>();
    public override void OnFixedUpdate()
    {
        velocity = strategy.onUpdateObject.vector;
        rigidbody.velocity = velocity * speed;
    }

}
