using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Text text;
    public static int coinAmount;
    void Start()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = coinAmount.ToString();
        if(coinAmount > 37)
        {
            //button winScreen setActive
        }
    }
}
