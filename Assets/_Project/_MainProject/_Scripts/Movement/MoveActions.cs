using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveActions : MonoBehaviour
{
    IActionValues actionValues;
    Rigidbody2D rigidbody;

    Vector2 moveVec = Vector2.zero;

    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _speedFac;

    public float Speed { get; private set; }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (actionValues == null)
            return;

        if (actionValues.MyButtonActionVal)
            Speed = _speed * _speedFac;
        else Speed = _speed;

        moveVec = actionValues.MyValueActionVectorVal;
    }
    private void FixedUpdate()
    {
        if (actionValues == null)
            return;

        rigidbody.AddForce(moveVec * Speed * Time.deltaTime);
    }

    public void SetActionValues(IActionValues actionValues)
    {
        this.actionValues = actionValues;
    }


}
