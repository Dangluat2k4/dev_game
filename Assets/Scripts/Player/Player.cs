using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player :Entity
{
    [Header("Move info")]
    public float moveSpeed = 12f;
    public float jumpForce;

    [Header("Dash info")]
    [SerializeField] private float dashCoolDown;
    private float dashUsageTimer;
    public float dashSpeed;
    public float dashDuration;
    public float dashDir { get; private set; }

    public float SwordReturnInpact;


    public PlayerStateMachine stateMachine { get; private set; }
    public PlayerIdleState idleState { get; private set; }

    public PlayerDashState dashState { get; private set; }

    public PlayerMoveState moveState { get; private set; }

    protected override void Awake()
    {
        base.Awake();
        stateMachine = new PlayerStateMachine();
        idleState = new PlayerIdleState(this, stateMachine, "Idle");
        dashState = new PlayerDashState(this, stateMachine, "Dash");
        moveState = new PlayerMoveState(this, stateMachine, "Move");
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
        CheckForDashInput();
    }

    //
    private void CheckForDashInput()
    {
        //if (IsWallDetected())
        //    return;

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
    public void AnimationTrigger() => stateMachine.currentState.AnimationFinishTriger();
}
