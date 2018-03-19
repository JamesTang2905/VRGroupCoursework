using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musictrigger : MonoBehaviour {

    public AudioClip music;
    private AudioSource source;
    public bool played = false;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !played)
        {
            source.Play();
            played = true;
        }
    }
}