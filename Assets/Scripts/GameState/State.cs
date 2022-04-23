using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class State<T> : SingletonMonoBehaviour<T>, IState where T : SingletonMonoBehaviour<T>
{
    public abstract void OnEnterState(IState previousState);
    public abstract void OnExitState(IState nextState);

    public void unLoadIngameScenes()
    {
        SceneManager.UnloadSceneAsync("InGame");
        SceneManager.UnloadSceneAsync("InGameUI");
        SceneManager.UnloadSceneAsync("InGameL1");
    }
}
