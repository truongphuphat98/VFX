using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOff : MonoBehaviour
{
    public GameObject Original;
    public GameObject Fake;

    public void VFXBox_EffectTurnOFF()
    {
        Original.SetActive(false);
        //Fake.SetActive(true);
    }

    public void VFXBox_SlotTurnON()
    {
        Original.SetActive(true);
        //Fake.SetActive(false);
    }
	

}
