using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {
    public string LevelName;
    LoaderScript loaderScript;
    GameManager gm; 
    private void Start()
    {
        loaderScript = GameObject.FindObjectOfType<LoaderScript>();
        gm = GameManager.Instance;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            loaderScript.LoadLevelAsync(LevelName);
            gm.LoadLevelAdditive("PlayerPreprefs");
        }
    }
}
