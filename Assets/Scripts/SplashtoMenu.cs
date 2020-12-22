using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashtoMenu : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RunSplash());
    }

    IEnumerator RunSplash(){
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(1);  //Menu
    }
}
