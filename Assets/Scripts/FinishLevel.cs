using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject winScreen;
    public GameObject[] winBarriers;
    public GameObject collectibleIndicator;
    public GameObject fadeOut;
    public Camera playerCamera;
    public Camera winCamera;
    
    private void OnTriggerEnter(){
        for (int i=0; i < winBarriers.Length; i++){
            winBarriers[i].SetActive(true);
        }
        if(collectibleIndicator.activeSelf){    //If UI indicator is active, aka rock was collected
            PlayerPrefs.SetInt("level" + RedirectLevels.current_level + "Collectible", 1);
        }
        PlayerPrefs.SetInt("level" + RedirectLevels.current_level + "Complete", 1);
        StartCoroutine(LevelWin());
    }
    
    IEnumerator LevelWin(){  
        levelMusic.SetActive(false);
        playerCamera.enabled = false;
        playerCamera.gameObject.GetComponent<AudioListener>().enabled = false;
        winCamera.enabled = true;
        winCamera.gameObject.GetComponent<AudioListener>().enabled = true;
        GetComponent<Animator>().enabled = true;
        levelComplete.Play();
        winScreen.SetActive(true);
        collectibleIndicator.SetActive(false);
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        RedirectLevels.Redirect(RedirectLevels.current_level + 1);  //Go to next level
    }
}
