using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public Text healthText;
    public Text coinText;
    public HealthBar health;
    public Coins coin;
    public GameObject winCanvas;

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

    public static void WinPanel(bool Active, GameObject WinCanvas)
    {
        WinCanvas.SetActive(Active);
        Dice.EnableDice = !Active;
    }

    public void ExitButton()
    {
        winCanvas.SetActive(false);
        SceneManager.LoadScene("Main Menu");


    }
}
