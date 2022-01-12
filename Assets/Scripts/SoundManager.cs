using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public AudioSource bgSound;
    public AudioSource sfxButton;
    public AudioSource sfxTrap;
    public AudioSource sfxLose;
    public AudioSource sfxWin;
    public AudioSource sfxCoin;

    private void Start()
    {
        bgSound.Play();
    }

    public void PlayButton()
    {
        sfxButton.Play();
    }

    public void Fire()
    {
        sfxTrap.Play();
    }

    public void LoseScreen()
    {
        sfxLose.Play();
    }

    public void WinScreen()
    {
        sfxWin.Play();
    }

        public void GetCoin()
    {
        sfxCoin.Play();
    }
}