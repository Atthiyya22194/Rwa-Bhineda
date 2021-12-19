using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float timeLeft = 120f;
    public GameObject GameOver;

    void Start()
    {
        GameOver.SetActive(false);
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            GameOver.SetActive(true);
        }
    }
}
