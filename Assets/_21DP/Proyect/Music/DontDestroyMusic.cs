using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
    public static AudioSource audiosource;
    private void Awake()
    {
        if (audiosource != null)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            audiosource = GetComponent<AudioSource>();
        }
         
    }


    public void PLayMusic()
    {
        if (audiosource.isPlaying) return;
        audiosource.Play();
    }
    public void StopMusic()
    {
        audiosource.Stop();
    }
}
