using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

    GameManager gm;
	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
        gm = GameManager.Instance;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)&& gm.isPauseLoaded == true)
        {
            UnloadPause("PauseMenu");
        }
	}
    public void UnloadPause(string level)
    {
        GameManager.Instance.isPauseLoaded = false;
        GameManager.Instance.UnloadLevel(level);
    }

    private void OnDestroy()
    {
        Time.timeScale = 1;
    }
}
