using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ChienHoang
{
    public class StateMachinePlayer<T>
    {
        public State<T> _currentState;
        public T Owner;

        public StateMachinePlayer(T _o)
        {
            _currentState = null;
            Owner = _o;
        }

        public void ChangeState(State<T> newState)
        {
            if(_currentState !=null)
            {
                _currentState.Exit(Owner);
            }    
            _currentState = newState;
            _currentState.Enter(Owner);
        }

        public void Update()
        {
            if(_currentState != null)
            {
                _currentState.LogicUpdate(Owner);
            }    
        }

        public void FixedUpdate()
        {
            if(_currentState != null)
            {
                _currentState.PhysicUpdate(Owner);
            }    
        }
    }

    public abstract class State<T>
    {
        public abstract void Enter(T owner);
        public abstract void Exit(T owner);
        public abstract void LogicUpdate(T owner);
        public abstract void PhysicUpdate(T owner);
    }
}
