using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escapetrigger : MonoBehaviour {

    public bool triggered = false;

	// Use this for initialization
	void Start () {
	}

    void OnTriggerEnter(Collider col)
    {
        //check for player
        if (col.gameObject.tag == "Player")
        {
            //escape
            triggered = true;
        }
    }
}
