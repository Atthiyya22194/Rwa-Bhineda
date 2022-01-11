using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Audio;
using UnityEngine.UI;

public class bgSound : MonoBehaviour
{     
    //public AudioSource audio;
    [SerializeField] Image iconOn;
    [SerializeField] Image iconOff;
    private bool muted = false;

    void Start()
    {
        //audio.Play();
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;
    }

    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        Save();
        UpdateButtonIcon();
    }

    private void UpdateButtonIcon()
    {
        if(muted == false)
        {
            iconOn.enabled = true;
            iconOff.enabled = false;
        }
        else
        {
            iconOn.enabled = false;
            iconOff.enabled = true;
        }
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }

    /*
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audio.mute = !audio.mute;
        }
    }
    
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
