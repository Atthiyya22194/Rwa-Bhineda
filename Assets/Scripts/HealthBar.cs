using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    private float currentHealth;
    static public float health;
    Image healthBar;
    int maxHealth = 100;
    public GameObject gameOver;
    public bool isPlayerDead;

    private void Awake()
    {
        DontDestroyOnLoad(GameObject.Find("HealthBar"));
    }

    void Start()
    {
        gameOver.SetActive(false);
        healthBar = GetComponent<Image>();
        isPlayerDead = false;
        CheckHealth();
    }

    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
        SaveSystem.SetFloat("health", health);
        if (health == 0)
        {
            isPlayerDead = true;
            gameOver.SetActive(true);
        }
    }

    private void CheckHealth()
    {
        if (SceneManager.GetActiveScene().name == "Stage 1")
        {
            health = maxHealth;
        }
        else if (SceneManager.GetActiveScene().name == "Stage 2")
        {
            health = SaveSystem.GetFloat("health");
        }
    }
}