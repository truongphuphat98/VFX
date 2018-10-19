using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RandomAudio : MonoBehaviour
{
    public AudioClip[] soundtrack;
    private AudioSource audioSource;

    public Slider musicSlider;

    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
    }

    private AudioClip GetRandomClip()
    {
        return soundtrack[Random.Range(0, soundtrack.Length)];
    }

    void Update()
    {
        if(!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();

        }
        AdjustingMusic();
    }

    void AdjustingMusic()
    {
        audioSource.volume = musicSlider.value;
    }
}
