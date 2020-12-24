using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{

public GameObject youDied;
public GameObject levelAudio;
public GameObject playerCamera;
public GameObject player;
public GameObject fadeOut;

private Animator anim;

    void Start(){
        anim = player.GetComponentInChildren<Animator>();
    }
    
    void OnTriggerEnter() {
        anim.SetTrigger("Dead");
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
        RedirectLevels.Redirect(RedirectLevels.current_level);
    }

}
