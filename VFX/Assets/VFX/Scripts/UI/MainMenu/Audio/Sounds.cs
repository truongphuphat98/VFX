using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public Slider soundeffectSlider;
    public AudioSource sound;

    void Update()
    { AdjustingSounds(); }



     void AdjustingSounds()
    {
        sound.volume = soundeffectSlider.value;
    }
}
