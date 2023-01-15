using UnityEngine.InputSystem;

public static class InputActionMapExt
{
    public static InputAction FindAction(this InputActionMap actionMap, InputAction inputAction)
    {
        return actionMap.FindAction(inputAction.name);
    }
}