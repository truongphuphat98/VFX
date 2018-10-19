using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionAnim : MonoBehaviour {

    Animator option;

    void Start()
    {
        option = GetComponent<Animator>();
    }

    public void B_Option()
    {
        GetComponent<Animator>().SetTrigger("IsToggle");
    }
}
