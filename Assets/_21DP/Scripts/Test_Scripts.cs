using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Scripts : MonoBehaviour
{
    [Header("PRUEBAS")]
    public string MyName = "GenericName";
    
    void Start()
    {
        Debug.Log("Hola, Me llamo " + MyName);
        
        

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<Rigidbody>().useGravity = true;
        }

    }
}