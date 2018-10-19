using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{
    public bool moveForward = false;
    public float MovementSpeedAI;

    void Update()
    {
        if (moveForward)
        {
            transform.Translate(Vector3.back * Time.deltaTime * MovementSpeedAI);
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * MovementSpeedAI);
        }
    }

    void OnTriggerEnter(Collider other)
    //void OnCollisionEnter(Collision collision)
    {
        if (other.tag == "Trigger")
        {
            moveForward = !moveForward;
        }
    }
}
