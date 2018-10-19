using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    [SerializeField]
    int Counter = 0;

    public GameObject Real;
    public GameObject Fake;
    bool isReal;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Counter++;
    }

    public void Activate()
    {
        if (isReal)
            Real.SetActive(true);
        Fake.SetActive(false);
        if (!isReal)
            Real.SetActive(false);
        Fake.SetActive(true);
    }
}
