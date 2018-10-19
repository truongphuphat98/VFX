using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastManager : MonoBehaviour
{
    public GameObject EffectPrefab;
    private GameObject EffectHandler;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayCast = Camera.main.ScreenPointToRay(Input.mousePosition);
            EffectHandler = Instantiate(EffectPrefab, rayCast.GetPoint(10), Quaternion.identity) as GameObject;
        }
    }
}
