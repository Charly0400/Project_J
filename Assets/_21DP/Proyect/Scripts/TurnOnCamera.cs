using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnCamera : MonoBehaviour
{
    public GameObject oa;


    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown (KeyCode.C))
        {
            oa.SetActive (true);
        }
    }

    void ActiveCamera()
    {
        Debug.Log("Hay bug");
    }
}
