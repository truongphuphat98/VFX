using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using UnityEngine;

public class UI_Language : MonoBehaviour
{
    [Header("English Menu")]
    public GameObject Start;
    public GameObject Instructions;
    public GameObject Settings;
    public GameObject Quit;
    [Header("English Settings")]
    public GameObject SettingsTitle;
    public GameObject SettingsMusiqueVolume;
    public GameObject Languagetitle;
    public GameObject DefaultTitle;
    public GameObject SettingsApply;
    [Header("English Helper")]
    public GameObject InstructionInstruct;
    public GameObject Return;

    [Header("French Menu")]
    public GameObject Commencer;
    public GameObject Aide;
    public GameObject Parametre;
    public GameObject Quitter;
    [Header("French Settings")]
    public GameObject ParametreTitre;
    public GameObject ParametreVolumeMusique;
    public GameObject TitreLangue;
    public GameObject DefaultTitre;
    public GameObject ParamtreAppliquer;
    [Header("French Helper")]
    public GameObject Instructionstext;
    public GameObject Retour;

    private Main_LangUI mainScene_LanguageChangeUI;

    public void French()
    {
        Commencer.SetActive(true);
        Start.SetActive(false);
        Aide.SetActive(true);
        Instructions.SetActive(false);
        Parametre.SetActive(true);
        Settings.SetActive(false);
        Quitter.SetActive(true);
        Quit.SetActive(false);

        ParametreTitre.SetActive(true);
        SettingsTitle.SetActive(false);
        ParametreVolumeMusique.SetActive(true);
        SettingsMusiqueVolume.SetActive(false);
        TitreLangue.SetActive(true);
        Languagetitle.SetActive(false);
        DefaultTitre.SetActive(true);
        DefaultTitle.SetActive(false);
        ParamtreAppliquer.SetActive(true);
        SettingsApply.SetActive(false);

        Instructionstext.SetActive(true);
        InstructionInstruct.SetActive(false);
        Retour.SetActive(true);
        Return.SetActive(false);

        mainScene_LanguageChangeUI.textPartager.SetActive(true);
        mainScene_LanguageChangeUI.textShare.SetActive(false);
        mainScene_LanguageChangeUI.instructions_FR.SetActive(true);
        mainScene_LanguageChangeUI.instructions_EN.SetActive(false);
        mainScene_LanguageChangeUI.textParametre.SetActive(true);
        mainScene_LanguageChangeUI.textSettings.SetActive(false);
        mainScene_LanguageChangeUI.volumeMusique.SetActive(true);
        mainScene_LanguageChangeUI.musicVolume.SetActive(false);
        mainScene_LanguageChangeUI.effetsSonores.SetActive(true);
        mainScene_LanguageChangeUI.soundEffets.SetActive(false);
        mainScene_LanguageChangeUI.appliquer.SetActive(true);
        mainScene_LanguageChangeUI.apply.SetActive(false);

    }

    public void English()
    {
        Commencer.SetActive(false);
        Start.SetActive(true);
        Aide.SetActive(false);
        Instructions.SetActive(true);
        Parametre.SetActive(false);
        Settings.SetActive(true);
        Quitter.SetActive(false);
        Quit.SetActive(true);

        ParametreTitre.SetActive(false);
        SettingsTitle.SetActive(true);
        ParametreVolumeMusique.SetActive(false);
        SettingsMusiqueVolume.SetActive(true);
        TitreLangue.SetActive(false);
        Languagetitle.SetActive(true);
        DefaultTitre.SetActive(false);
        DefaultTitle.SetActive(true);
        ParamtreAppliquer.SetActive(false);
        SettingsApply.SetActive(true);

        Instructionstext.SetActive(false);
        InstructionInstruct.SetActive(true);
        Retour.SetActive(false);
        Return.SetActive(true);

        mainScene_LanguageChangeUI.textPartager.SetActive(false);
        mainScene_LanguageChangeUI.textShare.SetActive(true);
        mainScene_LanguageChangeUI.instructions_FR.SetActive(false);
        mainScene_LanguageChangeUI.instructions_EN.SetActive(true);
        mainScene_LanguageChangeUI.textParametre.SetActive(false);
        mainScene_LanguageChangeUI.textSettings.SetActive(true);
        mainScene_LanguageChangeUI.volumeMusique.SetActive(false);
        mainScene_LanguageChangeUI.musicVolume.SetActive(true);
        mainScene_LanguageChangeUI.effetsSonores.SetActive(false);
        mainScene_LanguageChangeUI.soundEffets.SetActive(true);
        mainScene_LanguageChangeUI.appliquer.SetActive(false);
        mainScene_LanguageChangeUI.apply.SetActive(true);
    }
}
