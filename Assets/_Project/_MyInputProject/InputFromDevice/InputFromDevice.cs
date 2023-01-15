using UnityEngine;
using UnityEngine.InputSystem;

public class InputFromDevice : MonoBehaviour
{
    [SerializeField]
    Vector2 mouseVec;
    [SerializeField]
    bool bottonPressed;
    [SerializeField]
    bool bottonReleased;
    [SerializeField]
    bool bottonIsPressed;
    [SerializeField]
    float spaceValue;
    [SerializeField]
    bool spaceIsPressed;
    private void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            bottonPressed = true;
        }
        if (Keyboard.current.anyKey.wasReleasedThisFrame)
        {
            bottonReleased = true;
        }

        bottonIsPressed = Keyboard.current.anyKey.isPressed;

        //jep, this returns 0 / 1 not true / false !!
        spaceValue = Keyboard.current.spaceKey.ReadValue();

        spaceIsPressed = Keyboard.current.spaceKey.isPressed;

        mouseVec = Mouse.current.position.ReadValue();
    }
}
