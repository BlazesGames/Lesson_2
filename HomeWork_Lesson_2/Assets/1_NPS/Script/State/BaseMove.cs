public class BaseMove : IState
{
    protected readonly IStateSwitcher stateSwitcher;
    protected readonly NpsData _npsData;
    protected readonly Nps nps;

    public BaseMove(IStateSwitcher _stateSwitcher, Nps _nps, NpsData npsData)
    {
        stateSwitcher = _stateSwitcher;
        nps = _nps;
        npsData = _npsData;
    }

    public virtual void Entre()
    {

    }

    public virtual void Exit()
    {

    }

    public virtual void Update()
    {

    }
}
