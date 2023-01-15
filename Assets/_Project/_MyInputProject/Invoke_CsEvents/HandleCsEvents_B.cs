using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class HandleCsEvents_B : MonoBehaviour, IActionValues
{
    PlayerInput playerInput;
    InputActions InputActions = PlayerManager.InputActions;
    InputActionMap actionMapA;

    [SerializeField]
    public bool MyButtonActionVal { get; private set; }

    public bool MyButtonAction_PressReleaseVal { get; private set; }

    public Vector2 MyValueActionVectorVal { get; private set; }

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        actionMapA = playerInput.GetActionMap(InputActions.MyActionMapA);

    }
    private void OnEnable()
    {
        InputAction MyAction;
        //MyAction = actionMapA
        //    .FindAction(InputActions.MyActionMapA.MyButtonAction.name);
        //MyAction.performed += (ctx) => MyAction_performed(ctx, true);
        //MyAction.canceled += (ctx) => MyAction_performed(ctx, false);

        MyAction = actionMapA
            .FindAction(InputActions.MyActionMapA.MyButtonAction);
        MyAction.performed += (ctx) => MyButtonActionVal = true;
        MyAction.canceled += (ctx) => MyButtonActionVal = false;

        MyAction = actionMapA
            .FindAction(InputActions.MyActionMapA.MyButtonAction_PressRelease);
        MyAction.performed += (ctx) => MyButtonAction_PressReleaseVal = true;
        MyAction.canceled += (ctx) => MyButtonAction_PressReleaseVal = false;

        MyAction = actionMapA
            .FindAction(InputActions.MyActionMapA.MyValueActionVector);
        MyAction.performed += (ctx) => MyValueActionVectorVal = MyAction.ReadValue<Vector2>();
        MyAction.canceled += (ctx) => MyValueActionVectorVal = Vector2.zero;

    }

    //private void MyAction_performed(InputAction.CallbackContext obj, bool check)
    //{
    //    MyButtonActionVal = check;
    //}

    private void OnDisable()
    {
        InputAction MyAction;
        //MyAction = actionMapA
        //    .FindAction(InputActions.MyActionMapA.MyButtonAction.name);
        //MyAction.performed -= (ctx) => MyAction_performed(ctx, true);
        //MyAction.canceled -= (ctx) => MyAction_performed(ctx, false);
        MyAction = actionMapA
            .FindAction(InputActions.MyActionMapA.MyButtonAction);
        MyAction.performed -= (ctx) => MyButtonActionVal = true;
        MyAction.canceled -= (ctx) => MyButtonActionVal = false;

        MyAction = actionMapA
            .FindAction(InputActions.MyActionMapA.MyButtonAction_PressRelease);
        MyAction.performed -= (ctx) => MyButtonAction_PressReleaseVal = true;
        MyAction.canceled -= (ctx) => MyButtonAction_PressReleaseVal = false;

        MyAction = actionMapA
            .FindAction(InputActions.MyActionMapA.MyValueActionVector);
        MyAction.performed -= (ctx) => MyValueActionVectorVal = MyAction.ReadValue<Vector2>();
        MyAction.canceled -= (ctx) => MyValueActionVectorVal = Vector2.zero;

    }


}
