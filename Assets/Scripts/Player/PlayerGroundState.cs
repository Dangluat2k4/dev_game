using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundState : PlayerState

{
    public PlayerGroundState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();

    }
    public override void Update()
    {
        base.Update();

        if (Input.GetKeyDown(KeyCode.J))
        {
            stateMachine.ChangeState(player.primaryAttack);
            Debug.Log("taans cong");

        }

        if (Input.GetKeyDown(KeyCode.Space) && player.IsGroundDetected())
        {
            stateMachine.ChangeState(player.jumpState);
            Debug.Log("jump");
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            stateMachine.ChangeState(player.lightBallState);
            Debug.Log("light Ball");
        }

    }
}
