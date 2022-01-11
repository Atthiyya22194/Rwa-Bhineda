using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgSound : MonoBehaviour
{
    public static bgSound music;

    // Start is called before the first frame update
    private void Awake()
    {
        if (music != null && music != this)
        {
            Destroy(this.gameObject);
            return;
        }
        music = this;
        DontDestroyOnLoad(this);
    }
}
