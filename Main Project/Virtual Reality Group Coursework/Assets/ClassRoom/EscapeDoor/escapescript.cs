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

public class escapescript : MonoBehaviour
{

    private Animator animator;
    bool doorOpened;
    GameObject trig;
    GameObject closet;

    // Use this for initialization
    void Start()
    {
        //door initially not open
        doorOpened = false;
        animator = GetComponent<Animator>();
        trig = GameObject.Find("Origin/EscapeTrigger");
        closet = GameObject.Find("Origin/ClosetDoor");
    }

    //trigger function
    void OnTriggerEnter(Collider col)
    {
        //check for player
        if (col.gameObject.tag == "Player" && trig.GetComponent<escapetrigger>().triggered)
        {
            doorOpened = true;
            door("open");
        }
    }

    //closing the door when leaving trigger area
    void OnTriggerExit(Collider col)
    {
        if (doorOpened)
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
