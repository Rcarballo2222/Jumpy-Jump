using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    public GameObject ScoreBox;
    public AudioSource collectSound;

    // Start is called before the first frame update
    void OnTriggerEnter() {
        GlobalScores.num_collectibles += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
