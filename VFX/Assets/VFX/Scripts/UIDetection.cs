using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIDetection : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Raycast rayScript;
    public bool isOver = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        rayScript.isOverUI = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rayScript.isOverUI = false;
    }
}
