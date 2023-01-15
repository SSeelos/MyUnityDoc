using UnityEngine.InputSystem;

public static class PlayerInput_Ext
{
    public static InputActionMap GetActionMap(this PlayerInput playerInput, InputActions.MyActionMapAActions actions)
    {
        return playerInput.actions
            .FindActionMap(actions._GetNameDummy.actionMap.name);
    }
    public static InputActionMap GetActionMap(this PlayerInput playerInput, InputActions.MyActionMapBActions actions)
    {
        return playerInput.actions
            .FindActionMap(actions._GetNameDummy.actionMap.name);
    }

}

