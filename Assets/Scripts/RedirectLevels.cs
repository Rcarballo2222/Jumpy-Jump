using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectLevels : MonoBehaviour
{
    public static int redirect_to_level = 1;

    // Update is called once per frame
    void Update()
    {
        if (redirect_to_level == 1){    //Restart Level
            SceneManager.LoadScene(redirect_to_level);
            GlobalScores.num_collectibles = 0;  //Reset score
        }
    }
}
