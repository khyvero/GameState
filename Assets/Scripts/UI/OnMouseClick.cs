using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnMouseClick : MonoBehaviour
{
    public void StartBtnOnClick()
    {
        GameStateManager.Instance.GoToState(InGameState.Instance);
    }

    public void ContinueBtnOnClick()
    {
        GameStateManager.Instance.GoToState(InGameState.Instance);
    }

    public void ExitGameBtnOnClick()
    {
        GameStateManager.Instance.GoToState(MenuState.Instance);
    }

    public void ToMenuBtnOnClick()
    {
        GameStateManager.Instance.GoToState(MenuState.Instance);
    }

    public void QuitBtnOnClick()
    {
        Application.Quit();
    }
}
