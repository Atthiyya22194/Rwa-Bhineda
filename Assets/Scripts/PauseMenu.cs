using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PanelPause;

    private void Start()
    {
        PanelPause.SetActive(false);
    }

    public void Paused()
    {
        PanelPause.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        PanelPause.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
