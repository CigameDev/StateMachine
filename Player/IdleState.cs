using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ChienHoang;

public class IdleState : State<Player>
{
    private static IdleState _instance;

    private IdleState()
    {
        if(_instance != null)
        {
            return;
        }   
        _instance = this;
    }

    public static IdleState Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new IdleState();
            }    
            return _instance;
        }
    }
    public override void Enter(Player owner)
    {
        Debug.Log("chuyen sang trang thai Idle");
    }

    public override void Exit(Player owner)
    {
        Debug.Log("Thoat khoi trang thai Idle");
    }

    public override void LogicUpdate(Player owner)
    {
        if(Input.GetMouseButtonDown(0))
        {
            owner.stateMachine.ChangeState(MoveState.Instance);
        }
    }

    public override void PhysicUpdate(Player owner)
    {
        
    }
}
