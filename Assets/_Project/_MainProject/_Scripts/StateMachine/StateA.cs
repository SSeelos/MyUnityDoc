
using System.Reflection;

public class StateA : _State
{
    public StateA(StateManager manager) : base(manager)
    {

    }
    public override void Enter()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

    }

    public override void Update()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

        _stateManager.SwitchState(_stateManager.stateB);
    }

    public override void Exit()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());
    }
}

