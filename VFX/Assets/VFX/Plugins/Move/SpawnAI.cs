using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAI : MonoBehaviour
{
    public GameObject myPrefab;

    void Update()
    {
            GameObject go = (GameObject)Instantiate(myPrefab);
    }
}
