using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public AudioSource sfxButton;
    public AudioSource sfxHurt;
    public AudioSource sfxPick;
    public void PlayButton()
    {
        sfxButton.Play();
    }

    public void PlayHurt()
    {
        sfxHurt.Play();
    }

    public void PlayPick()
    {
        sfxPick.Play();
    }
}