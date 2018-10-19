using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Raycast : MonoBehaviour
{
    public GameObject[] objectToInstantiate;
    public Vector3 posSol;
    float half;
    public RaycastHit hit;
    public int i;

    public bool isOverUI = false;

    void Update()
    {
		if(Input.GetMouseButtonDown(0))
       		Pop();
    }

    public void Pop()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 10000.0f))
        {
            Debug.DrawRay(ray.origin, hit.point, Color.red);
            posSol = new Vector3(hit.point.x, hit.point.y, hit.point.z);

            while (i < 6)
            {
                if (UI_Manager.instance.button[i] == true)
                {
                    Instantiate(objectToInstantiate[i], posSol, Quaternion.identity);
                }
                i++;
            }
            i = 0;
        }
    }
}
