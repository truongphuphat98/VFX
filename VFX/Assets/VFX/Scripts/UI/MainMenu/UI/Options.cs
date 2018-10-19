using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject mainMenuHolder;
    public GameObject optionMenuHolder;
    public GameObject helperMenuHolder;

    public void OptionMenu()
    {
        mainMenuHolder.SetActive(false);
        optionMenuHolder.SetActive(true);
    }

    public void MainMenu()
    {
        mainMenuHolder.SetActive(true);
        optionMenuHolder.SetActive(false);
        helperMenuHolder.SetActive(false);
    }

    public void HelperMenu()
    {
        mainMenuHolder.SetActive(false);
        helperMenuHolder.SetActive(true);
    }
}
