using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class PlayerInput_Observer : MonoBehaviour
{
    PlayerInput playerInput;
    InputActions InputActions = PlayerManager.InputActions;
    IActionValues actionValues;


    [SerializeField]
    string name;
    [SerializeField]
    string map;
    [SerializeField]
    string actions;
    [SerializeField]
    string nameMapA;
    [SerializeField]
    string nameMapB;
    [SerializeField]
    string MyActionMapA;
    [SerializeField]
    string MyActionMapB;

    [SerializeField]
    bool MyButtonActionVal;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        actionValues = GetComponent<IActionValues>();

    }

    private void Update()
    {

        name = playerInput.name;
        map = playerInput.currentActionMap.name;
        actions = playerInput.actions.name;

        nameMapA = GetName(InputActions.MyActionMapA);
        nameMapB = GetName(InputActions.MyActionMapB);
        MyActionMapA = playerInput.actions
            .FindActionMap(nameMapA).name;
        MyActionMapB = playerInput.actions
            .FindActionMap(nameMapB).name;

        MyButtonActionVal = actionValues.MyButtonActionVal;
    }

    public string GetName(InputActions.MyActionMapAActions mapA)
    {
        return mapA.MyButtonAction.actionMap.name;
    }
    public string GetName(InputActions.MyActionMapBActions t)
    {
        return t.MyButtonActionB.actionMap.name;
    }
}
