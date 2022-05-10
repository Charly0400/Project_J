using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambiodeescena : MonoBehaviour
{

    private Fade fade;

    private void Awake()
    {
        fade = FindObjectOfType<Fade>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            fade.HacerFade();
    }

}
