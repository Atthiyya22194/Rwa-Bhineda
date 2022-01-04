using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public static AudioClip PlayerFiresound, getcoin;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        PlayerFiresound = Resources.Load<AudioClip>("Playerhit");
        getcoin = Resources.Load<AudioClip>("getcoin");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        
    }
}