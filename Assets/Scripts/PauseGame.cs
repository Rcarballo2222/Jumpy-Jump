using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool gamePaused = false;
    public GameObject pauseScreen;
    public AudioSource levelMusic;
    public AudioSource footstepSound;

    void Update(){
        if(Input.GetButtonDown("Cancel")){
            if(gamePaused == false){
                Time.timeScale = 0;
                pauseScreen.SetActive(true);
                gamePaused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                footstepSound.Pause();
            } else {
                UnPause();
            }
        }
    }

    public void UnPause(){
        Cursor.visible = false;
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
        gamePaused = false;
        levelMusic.UnPause();
        footstepSound.UnPause();
    }

    public void MainMenu(){
        UnPause();
        RedirectLevels.Redirect(-2);    //Go to Main Menu
    }

    public void RestartLevel(){
        UnPause();
        RedirectLevels.Redirect(RedirectLevels.current_level);
    }
}
