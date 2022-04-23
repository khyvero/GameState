using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameState : State<InGameState>
{
    //int level = 1;
    bool inPause = false;

    private void Update()
    {
        if (this == GameStateManager.Instance.GetCurrentState())
        {
            if (Input.GetKey(KeyCode.Escape) && !inPause)
            {
                inPause = true;
                GameStateManager.Instance.GoToState(PauseState.Instance);
            }
            else
            {
                inPause = false;
            }
        }
    }

    public override void OnEnterState(IState previousState)
    {
        if (PauseState.Instance != previousState)
        {
            SceneManager.LoadSceneAsync("InGame", LoadSceneMode.Additive);
            SceneManager.LoadSceneAsync("InGameUI", LoadSceneMode.Additive);
            SceneManager.LoadSceneAsync("InGameL1", LoadSceneMode.Additive);

            //if (level == 1)
            //{
            //    SceneManager.LoadSceneAsync("Pasue", LoadSceneMode.Additive);
            //}
        }
    }

    public override void OnExitState(IState nextState)
    {
        if (nextState != PauseState.Instance)
        {
            unLoadIngameScenes();
        }
    }
}
