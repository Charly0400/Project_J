using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Light : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<Light>().intensity = 0;
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Light>().intensity = 20;
        } 
        
        
    }
}
