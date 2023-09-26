using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Nps : MonoBehaviour
{
    private NpsStateMachine _npsStateMachine;
    public NavMeshAgent _navMeshAgent;
    public NpsData npsData;
    

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _npsStateMachine = new NpsStateMachine(this, npsData);
    }

    private void Update()
    {
        _npsStateMachine.Update();
    }
    
}
