using System;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class InitState : State<InitState>
{

    public override void OnEnterState(IState previousState)
    {
        GameStateManager.Instance.GoToState(MenuState.Instance);
    }

    public override void OnExitState(IState nextState)
    {
        
    }
}
