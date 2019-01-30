using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnLightEnter : MonoBehaviour {
    public bool PlayerEntered;
	// Use this for initialization
	void Start () {
        PlayerEntered = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AsyncOperation ao = SceneManager.LoadSceneAsync("TalkWLight", LoadSceneMode.Additive);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerEntered = true;
            Debug.Log("Player Enters");
        }
        else
        {
            PlayerEntered = false;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerEntered = false;
        SceneManager.UnloadSceneAsync("TalkWLight");
    }
}
