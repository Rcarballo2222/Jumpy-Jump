using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject playerCamera;
    public GameObject winScreen;
    public GameObject[] winBarriers;
    public GameObject collectibleIndicator;
    
    private void OnTriggerEnter(){
        for (int i=0; i < winBarriers.Length; i++){
            winBarriers[i].SetActive(true);
        }
        StartCoroutine(LevelWin());
        RedirectLevels.Redirect(5);
    }
    
    IEnumerator LevelWin(){
        playerCamera.transform.parent = transform;
        GetComponent<Animator>().enabled = true; 
        levelMusic.SetActive(false);
        levelComplete.Play();
        winScreen.SetActive(true);
        collectibleIndicator.SetActive(false);
        yield return new WaitForSeconds(1);
    }
}
