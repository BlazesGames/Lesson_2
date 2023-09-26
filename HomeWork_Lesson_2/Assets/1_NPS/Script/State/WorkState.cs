using UnityEngine;

public class WorkState : BaseIdle
{
    private float bufTime;

    public WorkState(IStateSwitcher _stateSwitcher, Nps _nps, NpsData npsData) : base(_stateSwitcher, _nps, npsData)
    {

    }

    public override void Entre()
    {
        base.Entre();
        Debug.Log("Пришли на работу");
        bufTime = nps.npsData.timeWork;
    }

    public override void Update()
    {
        base.Update();
        if (bufTime > 0)
        {
            bufTime -= Time.deltaTime;
            Debug.Log("Работаем в поте лица");
        }
        else
        {
            stateSwitcher.SwitchState<MoveHomeState>();
        }
        
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("Пошли домой");
    }
}
