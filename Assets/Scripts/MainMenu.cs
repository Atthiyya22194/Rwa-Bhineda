using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    bool hasSeenIntro;

    private void Start()
    {
        Time.timeScale = 1;
        hasSeenIntro = PlayerPrefs.GetInt("HasSeen") == 1 ? true : false;
        Debug.Log(hasSeenIntro);
    }

    public void PlayGame()
    {
        
        /*SceneManager.LoadScene("Stage 1");*/
        if (!hasSeenIntro )
        {
            TransitionScene.ChangeScene("CutsceneIntro", "single");
            hasSeenIntro = true;
        }
        else if (hasSeenIntro == true)
        {
            TransitionScene.ChangeScene("CutsceneIntro", "single");
            CutsceneScript.canSkip = true;
        }
        
    }
        public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("HasSeen", hasSeenIntro ? 1 : 0);
        PlayerPrefs.Save();
    }
}
