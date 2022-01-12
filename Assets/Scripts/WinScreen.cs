using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public Text coinText;
    public HealthBar health;
    public Coins coin;
    public string SceneDestination;
    public string SceneMode;

    // Start is called before the first frame update
    void Start()
    {
        health = FindObjectOfType<HealthBar>();
        coin = FindObjectOfType<Coins>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextStage()
    {
        TransitionScene.ChangeScene(SceneDestination, SceneMode);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
