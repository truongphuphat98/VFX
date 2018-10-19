using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShowHideText : MonoBehaviour
{
    public GameObject Interfacetext;
    private UIMainScène Uimainscene;
    public bool hide;
    public float timer;

    void Start()
    {
        hide = true;
    }

    void Update()
    {
        timer -= Time.deltaTime;
    }

    public void HideAndShow()
    {

        if (hide == false && timer < 0)
        {
            Interfacetext.SetActive(false);
            hide = true;
            timer = 0.2f;
        }

        if (hide == true && timer < 0)
        {
            Interfacetext.SetActive(true);
            hide = false;
            timer = 0.2f;
        }
    }
}
