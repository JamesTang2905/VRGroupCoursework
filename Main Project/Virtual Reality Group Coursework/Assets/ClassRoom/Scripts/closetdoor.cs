using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Source of this thing
 * https://www.youtube.com/watch?v=nfV45mpskRI
 * 
 * Should help with myself if I forget
 * 
 */

[RequireComponent(typeof(AudioSource))]
public class closetdoor : MonoBehaviour {

    private Animator animator;
    bool doorOpened;

    //spooky mode on triggered once
    public bool spookyMode = false;
    public bool musicChange = false;

	// Use this for initialization
	void Start () {
        //door initially not open
        doorOpened = false;
        animator = GetComponent<Animator>();
	}

    //trigger function
    void OnTriggerEnter(Collider col)
    {
        //check for player
        if(col.gameObject.tag == "Player")
        {
            doorOpened = true;
            door("open");

            //spooky mode
            spookyMode = true;

            if(spookyMode && !musicChange)
            {
                AudioSource a = GetComponent<AudioSource>();
                a.Stop();
            }
            
        }
    }

    //closing the door when leaving trigger area
    void OnTriggerExit(Collider col)
    {
        if(doorOpened)
        {
            doorOpened = false;
            door("close");
        }
    }

    //trigger animation
    void door(string direction)
    {
        animator.SetTrigger(direction);
    }
}
