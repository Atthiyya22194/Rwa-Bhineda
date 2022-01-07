using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Image healthBar;
    int maxHealth = 100;
    public static float health;

    void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;
        //maxHealth = PlayerPrefs.GetInt("health");
    }
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
        //PlayerPrefs.SetInt("health", maxHealth);
    }
}
