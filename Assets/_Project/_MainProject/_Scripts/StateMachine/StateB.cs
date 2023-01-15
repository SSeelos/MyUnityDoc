
using System.Reflection;

public class StateB : _State
{
    public StateB(StateManager manager) : base(manager)
    {

    }
    public override void Enter()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

    }

    public override void Update()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

        _stateManager.SwitchState(_stateManager.stateA);
    }
    public override void Exit()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

    }
}

