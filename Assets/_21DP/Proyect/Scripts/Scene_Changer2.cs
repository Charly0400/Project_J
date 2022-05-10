using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Changer2 : MonoBehaviour
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
