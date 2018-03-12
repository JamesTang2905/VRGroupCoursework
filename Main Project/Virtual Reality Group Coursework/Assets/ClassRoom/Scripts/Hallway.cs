using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway : MonoBehaviour {

    public Camera c;
    public Material cameraMat;

	// Use this for initialization
	void Start () {
		if(c.targetTexture != null)
        {
            c.targetTexture.Release();
        }
        c.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMat.mainTexture = c.targetTexture;
	}
}
