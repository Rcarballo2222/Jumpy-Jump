using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    private int level_num;
    public GameObject fadeOut;
    public GameObject[] buttons;
    public GameObject[] collectibles;
    
    void Start(){
        for (int i=1; i < buttons.Length + 1; i++){
            if((i < buttons.Length) && PlayerPrefs.GetInt("level" + (i) + "Complete") == 1){
                buttons[i].SetActive(true);
            }
            if(PlayerPrefs.GetInt("level" + (i) + "Collectible") == 1){
                collectibles[i-1].SetActive(true);
            }
        }    
    }

    public void PlayLevel(){
        StartCoroutine(LevelTransition());
    }

    IEnumerator LevelTransition(){
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        level_num = int.Parse(EventSystem.current.currentSelectedGameObject.gameObject.GetComponentInChildren<Text>().text);
        RedirectLevels.Redirect(level_num);
    }
}
