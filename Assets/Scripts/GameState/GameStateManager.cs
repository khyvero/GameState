using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameStateManager : MonoBehaviour
{

    private IState currentState;
    public static GameStateManager Instance;

    private void Start()
    {
        Instance = this;
        GoToState(InitState.Instance);
    }

    public IState GetCurrentState()
    {
        return currentState;
    }

    public void GoToState(IState state)
    {
        //check for same state transition
        if (currentState == state)
        {
            return;
        }
        //execute current state exit
        if (currentState != null)
        {
            currentState.OnExitState(state);
        }

        IState previousState = currentState;

        this.currentState = state;

        state.OnEnterState(previousState);

    }

}
