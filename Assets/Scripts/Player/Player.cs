using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player :Entity
{
    [Header("Attack details")]
    public Vector2[] attackMovement;
    public bool isBusy { get; private set; }


    [Header("Move info")]
    public float moveSpeed = 12f;
    public float jumpForce;


    [Header("Dash info")]
    public float dashSpeed;
    public float dashDuration;
<<<<<<< HEAD
    public float dashDir { get; private set; }

=======
>>>>>>> parent of 9efa5eb (fix Dash, Animation)
    public float SwordReturnInpact;


    public PlayerStateMachine stateMachine { get; private set; }
    public PlayerIdleState idleState { get; private set; }
    public PlayerAirState airState { get; private set; }
    public PlayerMoveState moveState { get; private set; }
    public PlayerJumpState jumpState { get; private set; }
<<<<<<< HEAD
    public PlayerDashState dashState { get; private set; }
=======
>>>>>>> parent of 9efa5eb (fix Dash, Animation)
    public PlayerPrimaryAttack primaryAttack { get; private set; }

    protected override void Awake()
    {
        base.Awake();
        stateMachine = new PlayerStateMachine();
        idleState = new PlayerIdleState(this, stateMachine, "Idle");

        moveState = new PlayerMoveState(this, stateMachine, "Move");

        airState = new PlayerAirState(this, stateMachine, "Jumping");

        dashState = new PlayerDashState(this, stateMachine, "Dash");

        jumpState = new PlayerJumpState(this, stateMachine, "Jumping");

        primaryAttack = new PlayerPrimaryAttack(this, stateMachine, "Attack");
    }

    protected override void Start()
    {
        base.Start();
        stateMachine.Initialize(idleState);
    }

    protected override void Update()
    {
        base.Update();
        stateMachine.currentState.Update();
    }
    public IEnumerator BusyFor(float _seconds)
    {
        isBusy = true;
        yield return new WaitForSeconds(_seconds);
        isBusy = false;
    }

    public void AnimationTrigger() => stateMachine.currentState.AnimationFinishTriger();
<<<<<<< HEAD

    private void CheckForDashInput()
    {
        if (IsWallDetected())
            return;

        dashUsageTimer -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.LeftShift) && dashUsageTimer < 0)
        {
            dashUsageTimer = dashCoolDown;
            dashDir = Input.GetAxisRaw("Horizontal");

            if (dashDir == 0)
                dashDir = facingDir;

            stateMachine.ChangeState(dashState);
        }
    }
=======
>>>>>>> parent of 9efa5eb (fix Dash, Animation)
}
