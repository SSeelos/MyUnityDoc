
using UnityEngine;

public class ColliderHandler : MonoBehaviour
{
    string targetTag;
    LayerMask targetLayer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.IsIgnoringCollision(collision.gameObject))
            return;

        ProcessCollision(collision.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ProcessCollision(collision.gameObject);
    }
    void ProcessCollision(GameObject collider)
    {
        if (!collider.CompareTag(targetTag) ||
            !collider.CompareLayer(targetLayer))
            return;

        //...
    }
}

