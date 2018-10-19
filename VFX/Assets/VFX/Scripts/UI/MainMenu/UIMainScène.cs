using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainScène : MonoBehaviour
{
    [Header("Options")]
    public GameObject _OptionsAudio;

    [Header("Tutorial")]
    public GameObject _Tuto;

    //[Header("Modes")]
    //public GameObject _VisualEffectsBox;
    //public GameObject _OptionSettings;
    //public GameObject _ShareFtEraseAll;

    [Header("Customization")]
    public GameObject _CustomizeVisualEffectBox;
    public GameObject _VisualEffectsBox01;

    public void OptionAudio_OpenOptions()
    {
        _OptionsAudio.SetActive(true);
        //_Tuto.SetActive(false);
    }
    public void OptionAudio_CloseOptions()
    {
        _OptionsAudio.SetActive(false);
        //_Tuto.SetActive(false);
    }

    //public void Modes_Observe()
    //{
    //    _VisualEffectsBox.SetActive(false);
    //    _OptionSettings.SetActive(false);
    //    _ShareFtEraseAll.SetActive(false);
    //}
    //public void Modes_Edit()
    //{
    //    _VisualEffectsBox.SetActive(true);
    //    _OptionSettings.SetActive(false);
    //    _ShareFtEraseAll.SetActive(false);
    //}
    //public void Modes_Camera()
    //{
    //    _VisualEffectsBox.SetActive(false);
    //    _OptionSettings.SetActive(true);
    //    _ShareFtEraseAll.SetActive(true);
    //}

    //public void OpenCustomization()
    //{
    //    _CustomizeVisualEffectBox.SetActive(true);
    //    _VisualEffectsBox01.SetActive(false);
    //}
    //Right Section
    //public void Customization_ApplyButton()
    //{
    //    _CustomizeVisualEffectBox.SetActive(false);
    //    _VisualEffectsBox01.SetActive(true);
    //}
    //public void Customization_CancelButton()
    //{
    //    _CustomizeVisualEffectBox.SetActive(false);
    //    _VisualEffectsBox01.SetActive(true);
    //}
    //public void Customization_DefaultButton()
    //{
    //    //Reset 
    //}
    //Left Section


    //Utilities
    public void CaptureScreenshot()
    {
        ScreenCapture.CaptureScreenshot("Screenshot.png");
        Debug.Log("Captured");
    }
    public void ClearAll()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("EffectPrefab");

        foreach (GameObject go in gos)
            Destroy(go);
    }
}
