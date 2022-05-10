using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public void Start()
    {
        GameObject.FindGameObjectWithTag("Music").
            GetComponent<DontDestroyMusic>().PLayMusic();
    }
}
