using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    
    public GameObject fadeOut;

    public void PlayGame(){
        StartCoroutine(LevelTransition());
    }

    public void QuitGame(){
        Application.Quit();
    }

    IEnumerator LevelTransition(){
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        RedirectLevels.Redirect(0);
    }
}
