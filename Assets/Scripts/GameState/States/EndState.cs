using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndState : State<EndState>
{
    void Update()
    {
        if (this == GameStateManager.Instance.GetCurrentState())
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                print("QuitGame");
                Application.Quit();
            }

            if (Input.GetKey(KeyCode.Return))
            {
                GameStateManager.Instance.GoToState(MenuState.Instance);
            }
        }
    }

    public override void OnEnterState(IState previousState)
    {
        //SceneManager.LoadScene("Ending");
        SceneManager.LoadSceneAsync("Ending", LoadSceneMode.Additive);
    }

    public override void OnExitState(IState nextState)
    {
        SceneManager.UnloadSceneAsync("Ending");
    }  
}
