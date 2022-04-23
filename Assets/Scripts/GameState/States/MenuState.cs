using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuState : State<MenuState>
{
    private void Update()
    {
        if (this == GameStateManager.Instance.GetCurrentState())
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                print("QuitGame");
                Application.Quit();
            }
        }
    }

    public override void OnEnterState(IState previousState)
    {
        //SceneManager.LoadScene("Menu");
        SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Additive);
        //Cursor.lockState = CursorLockMode.None;
    }

    public override void OnExitState(IState nextState)
    {
        SceneManager.UnloadSceneAsync("Menu");
    }
}
