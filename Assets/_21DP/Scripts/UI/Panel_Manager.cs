using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Manager : MonoBehaviour
{
    public GameObject[] panels;
    GameObject currentPanel;
    UI_Audio_Manager audioManager;

    private void Start()
    {
        audioManager = GetComponent<UI_Audio_Manager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           if (currentPanel == null) return;
            currentPanel.SetActive(false);
            audioManager.PlaySFX(2);

        } 
    }

    public void EnablePanel(int index)
    {
        currentPanel = panels[index];
        currentPanel.SetActive(true);
        audioManager.PlaySFX(2);

    }

}
