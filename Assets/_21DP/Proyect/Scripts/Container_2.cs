using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container_2 : MonoBehaviour
{
    public static int cubes2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cubes")
            cubes2++;
    }


}
