﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    void OnTriggerEnter() {
        SceneManager.LoadScene(0);    
    }

}
