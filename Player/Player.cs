using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ChienHoang;

public class Player : MonoBehaviour
{
    public StateMachinePlayer<Player> stateMachine;

    private void Start()
    {
        stateMachine = new StateMachinePlayer<Player>(this);
        stateMachine.ChangeState(IdleState.Instance);
    }

    private void Update()
    {
        stateMachine?.Update();
    }

    private void FixedUpdate()
    {
        stateMachine?.FixedUpdate();
    }
}
