using UnityEngine;

public class MoveAddForce : MonoBehaviour, IMoveVelocity
{
    private Rigidbody2D rigidbody;
    private Vector3 direction;

    public float accelaration = 10;
    public float maxSpeed = 10;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    public void SetVelocity(Vector3 velocity)
    {
        this.direction = velocity;
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(direction * accelaration);
        if (rigidbody.velocity.magnitude > maxSpeed)
            rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
    }

}
