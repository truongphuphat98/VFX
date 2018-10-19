using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPrefab : MonoBehaviour
{
    public float speed = 30.0f;

    void Update()
    {
        transform.Rotate(-Vector3.up * speed * Time.deltaTime);
    }    
	
}
