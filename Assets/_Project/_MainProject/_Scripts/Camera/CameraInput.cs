using UnityEngine;
using UnityEngine.InputSystem;

public class CameraInput : MonoBehaviour
{
    private Camera camera;

    [SerializeField]
    private InputAction zoomIn;
    [SerializeField]
    private InputAction zoomOut;

    [SerializeField]
    float speed;
    private void Awake()
    {
        this.camera = GetComponent<Camera>();
    }
    private void FixedUpdate()
    {
        if (zoomIn.ReadValue_FloatToBool())
            camera.orthographicSize -= speed;
        if (zoomOut.ReadValue_FloatToBool())
            camera.orthographicSize += speed;
    }
}
