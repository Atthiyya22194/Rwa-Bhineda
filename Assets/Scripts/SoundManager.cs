using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public AudioSource sfxButton;

    public void PlayButton()
    {
        sfxButton.Play();
    }
}