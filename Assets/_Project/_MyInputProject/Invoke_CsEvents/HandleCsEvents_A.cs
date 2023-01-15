using UnityEngine;
using UnityEngine.InputSystem;

public interface IActionValues
{
    bool MyButtonActionVal { get; }
    bool MyButtonAction_PressReleaseVal { get; }
    Vector2 MyValueActionVectorVal { get; }
}
[RequireComponent(typeof(PlayerInput))]
public class HandleCsEvents_A : MonoBehaviour, IActionValues
{
    PlayerInput playerInput;
    InputActions InputActions = PlayerManager.InputActions;

    InputAction MyButtonAction;
    public bool MyButtonActionVal
        => MyButtonAction.ReadValue_FloatToBool();
    InputAction MyButtonAction_PressRelease;
    public bool MyButtonAction_PressReleaseVal
        => MyButtonAction_PressRelease.ReadValue_FloatToBool();
    InputAction VectorAction;
    public Vector2 MyValueActionVectorVal
        => VectorAction.ReadValue<Vector2>();

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        InputActionMap mapA = playerInput.GetActionMap(InputActions.MyActionMapA);

        MyButtonAction = mapA
            .FindAction(InputActions.MyActionMapA.MyButtonAction);

        MyButtonAction_PressRelease = mapA
            .FindAction(InputActions.MyActionMapA.MyButtonAction_PressRelease);

        VectorAction = mapA
            .FindAction(InputActions.MyActionMapA.MyValueActionVector);
    }



    private void Update()
    {
        Debug.Log(playerInput.playerIndex.ToString() + ": "
            + MyValueActionVectorVal.ToString() + " "
            + MyButtonActionVal + " "
            + MyButtonAction_PressReleaseVal);
    }

}