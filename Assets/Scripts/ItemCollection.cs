using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    public AudioSource collectSound;
    public GameObject collect_indicator;

    // Start is called before the first frame update
    void OnTriggerEnter() {
        collect_indicator.SetActive(true);
        collectSound.Play();
        Destroy(gameObject);
    }
}
