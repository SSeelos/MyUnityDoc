using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class HandleCsEvents_C : MonoBehaviour, IActionValues
{
    PlayerInput playerInput;
    InputActions InputActions = PlayerManager.InputActions;

    InputAction MyButtonAction;
    public bool MyButtonActionVal { get; private set; }
    InputAction MyButtonAction_PressRelease;
    public bool MyButtonAction_PressReleaseVal { get; private set; }
    InputAction VectorAction;
    public Vector2 MyValueActionVectorVal { get; private set; }

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        InputActionMap mapA = playerInput.GetActionMap(InputActions.MyActionMapA);

        //MyButtonAction = mapA
        //    .FindAction(InputActions.MyActionMapA.MyButtonAction);
        MyButtonAction = playerInput.actions.FindAction(InputActions.MyActionMapA.MyButtonAction.name);

        MyButtonAction_PressRelease = mapA
            .FindAction(InputActions.MyActionMapA.MyButtonAction_PressRelease);

        VectorAction = mapA
            .FindAction(InputActions.MyActionMapA.MyValueActionVector);

    }
    private void OnEnable()
    {
        playerInput.onActionTriggered += PlayerInput_onActionTriggered;

    }
    private void OnDisable()
    {
        playerInput.onActionTriggered -= PlayerInput_onActionTriggered;
    }

    private void PlayerInput_onActionTriggered(InputAction.CallbackContext ctx)
    {
        InputAction action = ctx.action;
        if (action == MyButtonAction)
        {
            MyButtonActionVal = action.ReadValue_FloatToBool();
        }
        else if (action == MyButtonAction_PressRelease)
        {
            MyButtonActionVal = action.ReadValue_FloatToBool();
        }
        else if (action == VectorAction)
        {
            MyValueActionVectorVal = action.ReadValue<Vector2>();
        }
    }
}
