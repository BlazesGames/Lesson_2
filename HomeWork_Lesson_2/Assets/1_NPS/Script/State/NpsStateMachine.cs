using System.Collections.Generic;
using System.Linq;

public class NpsStateMachine : IStateSwitcher
{
    private List<IState> _states;
    private IState _currentState;

    public NpsStateMachine(Nps nps, NpsData data)
    {


        _states = new List<IState>()
        {
            new MoveWorkState(this, nps, data),
            new WorkState(this, nps, data),
            new MoveHomeState(this, nps, data),
            new HomeState(this, nps, data)
            
        };

        _currentState = _states[0];
        _currentState.Entre();
    }

    public void SwitchState<T>() where T : IState
    {
        IState state = _states.FirstOrDefault(state => state is T);
        _currentState.Exit();
        _currentState = state;
        _currentState.Entre();
    }

    public void Update() => _currentState.Update();
}
