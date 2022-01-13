using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    static public float health;
    Image healthBar;
    int maxHealth = 100;
    public GameObject winScreen;
    public bool isBossDead;

    void Start()
    {
        winScreen.SetActive(false);
        healthBar = GetComponent<Image>();
        health = maxHealth;
        isBossDead = false;
    }

    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
        if (health <= 0)
        {
            isBossDead = true;
            FindObjectOfType<SoundManager>().LoseScreen();
            winScreen.SetActive(true);
        }
    }
}
