using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class bgSound : MonoBehaviour
{     
    public AudioSource audio;

    void Start()
    {
        audio.Play();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            audio.mute = !audio.mute;
    }

    /*
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
    */
}
