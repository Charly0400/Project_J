using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Changer3 : MonoBehaviour
{
    private Fade fade;

    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

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
