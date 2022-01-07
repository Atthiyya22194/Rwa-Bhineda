using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private PlayerMovement player;
    Image healthBar;
    int maxHealth = 100;
    private float CurrentHealth;
    public static int health;

    void Start()
    {
        healthBar = GetComponent<Image>();
        player = FindObjectOfType<PlayerMovement>();
        health = maxHealth;
    }
    void Update()
    {
        CurrentHealth = player.health;
        healthBar.fillAmount = health / maxHealth;
    }
}
