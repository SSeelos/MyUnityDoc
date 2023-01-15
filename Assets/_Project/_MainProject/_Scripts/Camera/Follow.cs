using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField]
    private GameObject following;
    private Camera camera;

    private void Awake()
    {
        this.camera = GetComponent<Camera>();
    }
    private void LateUpdate()
    {
        if (following == null || camera == null)
            return;

        transform.position = new Vector3(
            following.transform.position.x,
            following.transform.position.y,
            transform.position.z);

        if (following.GetComponent<RelNToN>() is RelNToN rel)
            camera.orthographicSize = rel.maxDistance + 1;
    }
}
