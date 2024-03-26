using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine 
{
    // khai bao PlayerState
    public PlayerState currentState {  get; private set; }
    // lay gia tri cua no cong khai, doc duoc tu ben ngoai va thiet lap ben trong

    public void Intialize(PlayerState _startState)
    {
        currentState = _startState;
        currentState.Enter();
    }
    // khoi tao trang thai ban dau cua nguoi choi

    public void ChangState(PlayerState _newState)
    {
        currentState.Exit();
        currentState = _newState;
        currentState.Enter();
    }

}
