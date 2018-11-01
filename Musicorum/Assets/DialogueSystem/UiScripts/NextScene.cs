using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene : MonoBehaviour {

    public string sceneName;
    AsyncOperation async;
    bool waitForLoad;
    float timer, timerWait;
	// Use this for initialization
	void Start () {
        waitForLoad = false;
        timerWait = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {

        //if (Input.GetKeyDown(KeyCode.Space)) // Change the value later as the player moves towards the portal
        //{
        //    waitForLoad = true;
        //    async = SceneManager.LoadSceneAsync(sceneName);
        //    async.allowSceneActivation = false;
        //}
        //if (waitForLoad)
        //{
        //    timer += Time.deltaTime;
        //    if (timer >= timerWait /* || async.progress > 0.9f*/)
        //    {
        //        waitForLoad = false;
        //        async.allowSceneActivation = true;
        //    } 
        //}
	}
}
