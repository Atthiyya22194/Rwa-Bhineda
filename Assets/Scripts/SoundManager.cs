using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public AudioSource sfxButton;
    public AudioSource tes;

    public void PlayButton()
    {
        sfxButton.Play();
    }
    public void Fire()
    {
        sfxButton.Play();
    }
}