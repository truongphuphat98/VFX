using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyActivateAnim : MonoBehaviour
{
    Animator animtor;

    void Start()
    {
        animtor = GetComponent<Animator>();
    }

    public void B_EffectBox()
    {
        GetComponent<Animator>().SetTrigger("IsToggle");
    }
}
