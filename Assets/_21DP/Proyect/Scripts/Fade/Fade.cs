using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    /* public DontDestroyMusic music; //nuevo */
    private Animator anim;
    [SerializeField]
    string nivel;

   /* private void Start()
    {
        music = GetComponent<DontDestroyMusic>();//nuevo
    } */

    private void Awake()
    {
        anim = GetComponent<Animator>();

    }

    public void PasarNivel()
    {
        SceneManager.LoadScene(nivel);
        if (nivel == "TitleScreen2")
        {
         /*   music.enabled = false;//nuevo */
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void HacerFade()
    {
        anim.SetTrigger("FadeOut");
    }
}
