using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public Animator fadeboxAnimator;

    public void GoToScene(int index)
    {
        fadeboxAnimator.SetInteger("State", 1);
        StartCoroutine(WaitForFade(index));
        
    }

    IEnumerator WaitForFade(int index)
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(index);
    }
}
