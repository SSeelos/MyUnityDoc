public abstract class _State
{
    protected StateManager _stateManager;
    public _State(StateManager manager)
    {
        this._stateManager = manager;
    }
    public abstract void Enter();
    public abstract void Update();
    public abstract void Exit();
}
