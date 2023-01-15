using UnityEngine;
using UnityEngine.InputSystem;

public class HandleInputMessage : MonoBehaviour
{
    [SerializeField]
    bool buttonPressed;
    [SerializeField]
    bool buttonIsPressed;
    [SerializeField]
    Vector2 vec;
    void OnMyButtonAction()
    {
        buttonPressed = true;
    }
    void OnMyPressReleaseAction(InputValue value)
    {
        buttonIsPressed = value.isPressed;
    }
    void OnMyVectorAction(InputValue value)
    {
        vec = value.Get<Vector2>();
    }
}
