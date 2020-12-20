using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGrip : MonoBehaviour
{
    public GameObject platform;
    public GameObject player;

    private GameObject armature;
    private GameObject playerModel;
    private GameObject playerCamera;

    private void OnTriggerEnter() {
        armature = player.transform.GetChild(0).gameObject;
        playerModel = player.transform.GetChild(1).gameObject;
        playerCamera = player.transform.GetChild(2).gameObject;
        
        armature.transform.parent = platform.transform;
        playerModel.transform.parent = platform.transform;
        playerCamera.transform.parent = platform.transform;        
    }

    private void OnTriggerExit() {
        armature.transform.parent = player.transform;
        playerModel.transform.parent = player.transform;
        playerCamera.transform.parent = player.transform;
    }
}
