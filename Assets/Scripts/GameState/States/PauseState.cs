using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseState : State<PauseState>
{

    public override void OnEnterState(IState previousState)
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadSceneAsync("Pause", LoadSceneMode.Additive);

    }

    public override void OnExitState(IState nextState)
    {
        if (nextState == MenuState.Instance)
        {
            Time.timeScale = 1;
            SceneManager.UnloadSceneAsync("Pause");

            unLoadIngameScenes();
        }
        else
        {
            Time.timeScale = 1;
            SceneManager.UnloadSceneAsync("Pause");
        }
        
    }

    
}
