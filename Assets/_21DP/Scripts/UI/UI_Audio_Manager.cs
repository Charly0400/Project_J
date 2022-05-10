using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Audio_Manager : MonoBehaviour
{
    public AudioClip[] sfxClips;
    private AudioSource audioSource;


   
    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void PlaySFX(int index)
    {
        audioSource.clip = sfxClips[index];
        audioSource.Play();
    }
}
