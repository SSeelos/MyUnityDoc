using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]

public class HandleCsEvents_D : MonoBehaviour, IActionValues
{
    PlayerInput playerInput;
    InputActions _inputActions = PlayerManager.InputActions;
    public bool MyButtonActionVal { get; private set; }

    public bool MyButtonAction_PressReleaseVal { get; private set; }

    public Vector2 MyValueActionVectorVal { get; private set; }

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }
    private void OnEnable()
    {
        InputAction MyButtonAction = playerInput.actions.FindAction(_inputActions.MyActionMapA.MyButtonAction.id);
        MyButtonAction.performed += (ctx) => MyButtonActionVal = true;
        MyButtonAction.canceled += (ctx) => MyButtonActionVal = false;
    }
    private void OnDisable()
    {
        InputAction MyButtonAction = playerInput.actions.FindAction(_inputActions.MyActionMapA.MyButtonAction.id);
        MyButtonAction.performed -= (ctx) => MyButtonActionVal = true;
        MyButtonAction.canceled -= (ctx) => MyButtonActionVal = false;
    }
}
