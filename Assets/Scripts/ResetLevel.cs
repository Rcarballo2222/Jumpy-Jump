using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{

public GameObject youDied;
public GameObject levelAudio;

public GameObject playerCamera;

public GameObject fadeOut;

    void OnTriggerEnter() {
        StartCoroutine(YouDied());   
    }

    IEnumerator YouDied(){
        playerCamera.transform.parent = null;
        yield return new WaitForSeconds(.5f);
        youDied.SetActive(true);
        levelAudio.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        RedirectLevels.Redirect(1);
        
    }

}
