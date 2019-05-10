using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadHeathbar : MonoBehaviour {
    GameManager gm;
    public string WhatToLoadScene;
	// Use this for initialization
	void Start () {
        gm = GameManager.Instance;
        Loadlevel(WhatToLoadScene);
    }
    public void Loadlevel(string level)
    {
        gm.LoadLevelAdditive(level);
    }
}
