using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    public void buttonRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
