using UnityEngine;

public class HomeState : BaseIdle
{
    private float bufTime;

    public HomeState(IStateSwitcher _stateSwitcher, Nps _nps, NpsData npsData) : base(_stateSwitcher, _nps, npsData)
    {

    }

    public override void Entre()
    {
        base.Entre();
        Debug.Log("Пришёл домой нужно и поспать");
        bufTime = nps.npsData.timeWork;
    }

    public override void Update()
    {
        base.Update();
        if (bufTime > 0)
        {
            bufTime -= Time.deltaTime;
            Debug.Log("Спим и отдыхаем");
        }
        else
        {
            stateSwitcher.SwitchState<MoveWorkState>();
        }
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("Пора выдвигаться на работу");
    }
}
