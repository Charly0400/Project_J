using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
            Bird.currentTarget = transform;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            Bird.currentTarget = other.transform;
    }
}
