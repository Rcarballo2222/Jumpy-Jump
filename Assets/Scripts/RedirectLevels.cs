using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectLevels : MonoBehaviour
{
    
    public static int level_offset = 3;
    public static int current_level;
    private const int MAX_LEVEL = 3;
    
    public static void Redirect(int level){
        if(level == current_level){
            SceneManager.LoadScene(2);  //Redirect Level scene 
        } else {
            current_level = level;
        }

        if(level > MAX_LEVEL){
            Debug.Log("Exceeded Maximum Level!");
            SceneManager.LoadScene(1);  //Go to main menu
        }else {
            SceneManager.LoadScene(level + level_offset);
        }
        
    }

}
