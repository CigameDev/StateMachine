using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ChienHoang;

public class MoveState : State<Player>
{
    private static MoveState _instance;

    private MoveState()
    {
        if(_instance != null)
        {
            return;
        }
        _instance = this;
    }

    public static MoveState Instance
    {
        get
        {
            if (_instance ==null)
            {
                _instance = new MoveState();
            }
            return _instance;   
        }
    }
    public override void Enter(Player owner)
    {
        Debug.Log("chuyen sang trang thai Move state");
    }

    public override void Exit(Player owner)
    {
        Debug.Log("thoat khoi trang thai movestate");
    }

    public override void LogicUpdate(Player owner)
    {
        if (Input.GetMouseButtonDown(0))
        {
            owner.stateMachine.ChangeState(IdleState.Instance);
        }
    }

    public override void PhysicUpdate(Player owner)
    {
        
    }
}
