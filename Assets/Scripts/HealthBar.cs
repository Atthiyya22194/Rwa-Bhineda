using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject PanelGameOver;
    Image healthBar;
    int maxHealth = 100;
    public int currentHealth;
    public static int health;

    void Start()
    {
        health = currentHealth;
        PanelGameOver.SetActive(false);
        healthBar = GetComponent<Image>();
    }

    void Update()
    {
        healthBar.fillAmount = maxHealth - currentHealth;

        if(health < 0)
        {
            PanelGameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
