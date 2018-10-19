using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Credits : MonoBehaviour
{
    //Animator animtor;

    //void Start()
    //{
    //    animtor = GetComponent<Animator>();
    //}

    public void CreditsPlay()
    {
        //GetComponent<Animator>().SetTrigger("IsToggle");
        Application.LoadLevel(3);
    }
}
