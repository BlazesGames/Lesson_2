using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingState : GroundedState
{
    private readonly WalkStateConfig _config;

    public WalkingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.WalkStateConfig;

    public override void Enter()
    {
        base.Enter();
        Data.Speed = _config.SpeedWalk;

    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        base.Update();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
        else if (!IsWallkInput())
            StateSwitcher.SwitchState<RunningState>();
    }

}
