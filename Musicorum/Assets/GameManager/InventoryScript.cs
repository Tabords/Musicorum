using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour {

    GameManager Gm;
	// Use this for initialization
	void Start () {
        Gm = GameManager.Instance;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.I) && Gm.isInventoryLoaded == true && Gm.isPauseLoaded == false)
        {
            Gm.isInventoryLoaded = false;
            Gm.UnloadLevel("InventoryScene");
        } 
    }
}
