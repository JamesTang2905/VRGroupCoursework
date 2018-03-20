using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class endhorrors : MonoBehaviour {

    [SerializeField] private string loadLevel;

	void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            SceneManager.LoadScene(loadLevel);
        }
    }
}
