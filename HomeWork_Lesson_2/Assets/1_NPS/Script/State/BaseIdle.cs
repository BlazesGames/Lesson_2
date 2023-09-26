public class BaseIdle : IState
{
    protected readonly IStateSwitcher stateSwitcher;
    protected readonly NpsData _npsData;
    protected readonly Nps nps;

    public BaseIdle(IStateSwitcher _stateSwitcher, Nps _nps, NpsData npsData)
    {
        stateSwitcher = _stateSwitcher;
        npsData = _npsData;
        nps = _nps;
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
