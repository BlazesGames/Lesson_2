using UnityEngine;

public class MoveHomeState : BaseMove
{
    public MoveHomeState(IStateSwitcher _stateSwitcher, Nps _nps, NpsData npsData) : base(_stateSwitcher, _nps, npsData)
    {

    }

    public override void Entre()
    {
        base.Entre();
        nps._navMeshAgent.speed = nps.npsData.speed;
        nps._navMeshAgent.SetDestination(nps.npsData.pointHome.position);
        Debug.Log("��� �����");

    }

    public override void Update()
    {
        base.Update();
        Debug.Log("���, ������������ ������");
        if (Vector3.Distance(nps.transform.position, nps.npsData.pointHome.position) < nps.npsData.distanseToPoint)
        {
            stateSwitcher.SwitchState<HomeState>();
        }
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("������ �����");
    }
}
