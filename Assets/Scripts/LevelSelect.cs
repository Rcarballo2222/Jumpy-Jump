using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    private int level_num;
    public GameObject fadeOut;
    
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
