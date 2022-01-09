using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Image healthBar;
    int maxHealth = 100;
    public static int health;
    public GameObject gameOver;
    public bool isPlayerDead;

    void Start()
    {
        gameOver.SetActive(false);
        healthBar = GetComponent<Image>();
        health = maxHealth;
    }
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
        if (health <= 0)
        {
            isPlayerDead = true;
            gameOver.SetActive(true);
        }
    }
}