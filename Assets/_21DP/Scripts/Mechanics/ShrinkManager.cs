using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ShrinkArea")
        {
            transform.localScale *= 0.5f;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "ShrinkArea")
        {
            transform.localScale *= 2f;
        }
    }
}
