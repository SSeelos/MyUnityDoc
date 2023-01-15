using UnityEngine;

public class StateManager : MonoBehaviour
{
    _State currentState;

    public StateA stateA;
    public StateB stateB;

    private void Awake()
    {
        stateA = new StateA(this);
        stateB = new StateB(this);

        currentState = stateA;
        currentState.Enter();
    }
    private void Update()
    {
        currentState.Update();
    }

    public void SwitchState(_State state)
    {
        currentState.Exit();
        currentState = state;
        state.Enter();
    }
}
