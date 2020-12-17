using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGrip : MonoBehaviour
{
    public GameObject platform;
    public GameObject player;

    private void OnTriggerEnter() {
        player.transform.parent = platform.transform;        
    }

    private void OnTriggerExit() {
        player.transform.parent = null;
    }
}
