using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Music : MonoBehaviour
{
    public Slider musicSlider;
    public AudioSource music;

    void Update()
    { AdjustingMusic(); }

    void AdjustingMusic()
    {
        music.volume = musicSlider.value;
    }
}
