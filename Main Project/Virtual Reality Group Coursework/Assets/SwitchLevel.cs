using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevel : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter(Collider FPSController)
    {
        if (FPSController.gameObject.tag == "Player")
        {
            Scene sceneToLoad = SceneManager.GetSceneByName("Hub World");
            SceneManager.LoadScene(sceneToLoad.name, LoadSceneMode.Additive);
            SceneManager.MoveGameObjectToScene(FPSController.gameObject, sceneToLoad);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
