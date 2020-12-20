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
    
    private void OnTriggerEnter(){
        StartCoroutine(LevelWin());
    }
    
    IEnumerator LevelWin(){
        playerCamera.transform.parent = transform;
        GetComponent<Animator>().enabled = true; 
        levelMusic.SetActive(false);
        levelComplete.Play();
        winScreen.SetActive(true);
        yield return new WaitForSeconds(1);
    }
}
