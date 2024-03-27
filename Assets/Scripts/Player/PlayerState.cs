using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected PlayerStateMachine stateMachine;
    // tham chieu den trang thai hien tai cua nhan vat 
    public Player player;

    protected Rigidbody2D rb;
    protected float xInput;
    protected float yInput;
    private string animBoolName;

    protected float stateTimer;
    protected bool triggerCalled;

    public PlayerState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName)
    {
        this.player = _player;
        this.stateMachine = _stateMachine;
        this.animBoolName = _animBoolName;
    }


    public virtual void Enter()
    {
        // chuyen doi trang thai
        triggerCalled = false;

    }

    public virtual void Update()
    {
        stateTimer -= Time.deltaTime;

        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        // rb = player.rb;

    }
    public virtual void Exit()
    {

    }
    public virtual void AnimationFinishTriger()
    {
        triggerCalled = true;
    }
}
