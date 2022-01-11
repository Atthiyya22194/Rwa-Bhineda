using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSystem : MonoBehaviour
{
    //public static SaveSystem Instance;

    public static void SetFloat(string health, float value)
    {
        PlayerPrefs.SetFloat(health, value);
    }

    public static float GetFloat(string health)
    {
        return PlayerPrefs.GetFloat(health);
    }

    /*
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
    }
    */
}
