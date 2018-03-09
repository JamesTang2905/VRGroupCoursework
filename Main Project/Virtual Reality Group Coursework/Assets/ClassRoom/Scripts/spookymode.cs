using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spookymode : MonoBehaviour {

    GameObject closetDoor;
    bool musicChange;

	// Use this for initialization
	void Start () {
        closetDoor = GameObject.Find("Origin/ClosetDoor");
        musicChange = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(closetDoor.GetComponent<closetdoor>().spookyMode)
        {
            if(!musicChange)
            {
                AudioSource a = GetComponent<AudioSource>();
                a.Play();

                musicChange = true;
            }
        }
	}
}
