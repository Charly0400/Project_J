using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cage2 : MonoBehaviour
{
    public int CubesNecesary;
    public Looked door;

    void Update()
    {
        if (Container_2.cubes2 == CubesNecesary)
        {
            Invoke("OpenTheWaaay",0.1f);
        }
    }
    public void OpenTheWaaay()
    {
        door.OpenLock();


    }
}
