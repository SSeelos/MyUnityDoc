using UnityEngine;
using UnityEngine.InputSystem;

//[RequireComponent(typeof(IMoveVelocity))]
public class MovementInput : MonoBehaviour
{
    Vector3 moveDir;
    [SerializeField]
    Camera camera;
    private void Update()
    {
        moveDir.y = Input.GetAxisRaw("Vertical");
        moveDir.x = Input.GetAxisRaw("Horizontal");
        moveDir = moveDir.normalized;

        if (Input.GetKey(KeyCode.Mouse1))
            moveDir = (GetMousePosition() - transform.position).normalized;

        GetComponent<IMoveVelocity>().SetVelocity(moveDir);
    }
    private static Vector3 GetMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadDefaultValue());
    }
}
