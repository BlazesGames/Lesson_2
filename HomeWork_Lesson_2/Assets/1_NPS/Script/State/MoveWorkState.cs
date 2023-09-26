using UnityEngine;

public class MoveWorkState : BaseMove
{
    public MoveWorkState(IStateSwitcher _stateSwitcher, Nps _nps, NpsData npsData) : base(_stateSwitcher, _nps, npsData)
    {

    }

    public override void Entre()
    {
        base.Entre();
        nps._navMeshAgent.speed = nps.npsData.speed;
        nps._navMeshAgent.SetDestination(nps.npsData.pointWork.position);
    }

    public override void Update()
    {
        base.Update();
        Debug.Log("»ду на работу");
        if (Vector3.Distance(nps.transform.position, nps.npsData.pointWork.position) < nps.npsData.distanseToPoint)
        {
            stateSwitcher.SwitchState<WorkState>();
        }
    }

    public override void Exit()
    {
        base.Exit();
    }

}
