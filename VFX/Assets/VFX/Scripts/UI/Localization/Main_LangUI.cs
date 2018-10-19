using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using UnityEngine;

public class Main_LangUI : MonoBehaviour
{
    [Header("Partager")]
    public GameObject textPartager;
    [Header("Share")]
    public GameObject textShare;

    [Header("InstructionsFR")]
    public GameObject instructions_FR;
    [Header("InstructionsEN")]
    public GameObject instructions_EN;

    [Header("Paramètres")]
    public GameObject textParametre;
    public GameObject volumeMusique;
    public GameObject effetsSonores;
    public GameObject appliquer;
    [Header("Settings")]
    public GameObject textSettings;
    public GameObject musicVolume;
    public GameObject soundEffets;
    public GameObject apply;

    private UI_Language menuScene_LanguageChangeUI;

    void Update()
    {
        
    }
}
