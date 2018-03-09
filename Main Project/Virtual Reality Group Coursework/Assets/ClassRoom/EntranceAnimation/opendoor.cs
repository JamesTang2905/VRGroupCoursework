using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour {

    Animator animator;

    bool doorOpened;

    // Use this for initialization
    void Start()
    {
        //door initially not open
        doorOpened = false;
        animator = GetComponent<Animator>();
    }

    //trigger function
    void OnTriggerEnter(Collider col)
    {
        //check for player
        if (col.gameObject.tag == "Player")
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
