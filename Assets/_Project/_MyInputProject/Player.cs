using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class Player : MonoBehaviour
{
    PlayerInput playerInput;
    [SerializeField]
    int id => playerInput.playerIndex;
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        playerInput.onActionTriggered += PlayerInput_onActionTriggered;
    }

    private void PlayerInput_onActionTriggered(InputAction.CallbackContext ctx)
    {
        print(ctx.action.type);
        print(ctx.action.ToString());
        print(ctx.action.actionMap.actions);
        print(ctx.valueType);

        var actions = ctx.action.actionMap.actions;

        foreach (var action in actions)
        {
            print(action);
        }
    }
}
