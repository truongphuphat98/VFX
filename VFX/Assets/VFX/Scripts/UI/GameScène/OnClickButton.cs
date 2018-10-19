using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class OnClickButton : MonoBehaviour
{
    public int buttonNumber, i;
    public Button button;

    void Start()
    {
        button = GetComponent<Button>();
        Button ClickOn = button.GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        while (i < 6)
        {
            UI_Manager.instance.button[i] = false;
            i++;
        }
        i = 0;

        UI_Manager.instance.button[buttonNumber] = true;
    }
}


