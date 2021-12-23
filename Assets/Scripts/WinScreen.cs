using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    public Text healthText;
    public Text coinText;
    public HealthBar health;
    public Coins coin;

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
}
