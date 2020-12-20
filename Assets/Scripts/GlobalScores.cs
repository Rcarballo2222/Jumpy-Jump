using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScores : MonoBehaviour
{
    public static int num_collectibles;
    private int internal_num_collectibles;
    public GameObject collect_indicator;

    // Update is called once per frame
    void Update()
    {
        internal_num_collectibles = num_collectibles;
        if (internal_num_collectibles > 0){
            collect_indicator.GetComponent<Renderer>().enabled = true;
        }
    }
}
