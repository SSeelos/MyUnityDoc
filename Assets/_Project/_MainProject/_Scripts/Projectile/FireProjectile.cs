using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public Rigidbody2D projectilePrefab;
    public float speed = 4;

    public float rate;
    private float _counter;
    private bool IsFireing;
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            IsFireing = true;
        }
        else IsFireing = false;
    }
    private void FixedUpdate()
    {
        if (IsFireing)
        {
            _counter += Time.deltaTime;
        }

        if (_counter >= rate)
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation)
                .velocity = transform.up * speed;

            _counter = 0;
        }

    }
}
