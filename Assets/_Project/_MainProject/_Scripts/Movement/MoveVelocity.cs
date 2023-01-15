using UnityEngine;

public class MoveVelocity : MonoBehaviour, IMoveVelocity
{
    [SerializeField]
    private float speed;
    private Vector3 velocity;
    private Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    public void SetVelocity(Vector3 velocity)
    {
        this.velocity = velocity;
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = velocity * speed;
    }
}
