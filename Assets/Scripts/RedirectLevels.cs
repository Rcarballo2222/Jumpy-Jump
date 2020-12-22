using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectLevels : MonoBehaviour
{
    
    private const int level_offset = 3;

    public static void Redirect(int level){
        SceneManager.LoadScene(2);
        SceneManager.LoadScene(level + level_offset);
    }
}
