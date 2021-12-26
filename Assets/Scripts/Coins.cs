using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Text text;
    public static int coinAmount;
    public GameObject WinCanvas;
    public int MinCoin = 5;
    void Start()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        Debug.Log(coinAmount);
        text.text = coinAmount.ToString();
        if(coinAmount > MinCoin)
        {
            WinScreen.WinPanel(true, WinCanvas);
        }
    }

#if UNITY_EDITOR
    //this code block only compiled on unity editor, wont be taken on build
   
    [ContextMenu("TestUnlockStage")]
    void TestUnlockStage()
    {
        coinAmount = 38;
    }
#endif

    

}
