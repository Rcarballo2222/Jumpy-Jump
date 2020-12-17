using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolRockAnimator : MonoBehaviour
{
    public int rotationSpeed = 2;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, (.05f * rotationSpeed), 0, Space.World);   
    }
}
