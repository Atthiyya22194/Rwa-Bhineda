using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScene : MonoBehaviour
{
    public static void ChangeScene( string sceneName, string modeScene)
    {
        if (modeScene == "additive")
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }
        else if (modeScene == "single")
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
        
    }
}
