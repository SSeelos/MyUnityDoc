using UnityEngine.InputSystem;


public static class InputAction_Ext
{
    public static bool ReadValue_FloatToBool(this InputAction inputAction)
    {
        if (inputAction.ReadValue<float>() == 0) return false;
        else return true;
    }
}

