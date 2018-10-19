using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class VfxAcess : MonoBehaviour
{
    void Update()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            //Debug.Log("Not Passing through");
        }
    }


}
