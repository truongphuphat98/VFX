using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Loading : MonoBehaviour
{
    public float numberOfPercentage;
    public Text loadingPercentageText;

    public GameObject bar;

    public float timer = 5f;

    void Start()
    {
        //screen.SetActive(true);
    }

    void Update()
    {
        loadingPercentageText.text = "" + (int)numberOfPercentage + "%";
        bar.transform.localScale = new Vector3(numberOfPercentage / 100, 1, 1);

        if (numberOfPercentage < 100)
        {
            numberOfPercentage += Time.deltaTime * timer;
        }

        if (numberOfPercentage >= 100)
        {
            numberOfPercentage = 100;
            Application.LoadLevel(2);
        }
    }
}
