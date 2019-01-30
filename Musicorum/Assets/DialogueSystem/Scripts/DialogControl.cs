using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogControl : MonoBehaviour {

    int DialogCounter;
    [SerializeField] Text Text;
    [SerializeField] GameObject disablecanvas;
	// Use this for initialization
	void Start () {
        DialogCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextDialog();
        }
	}

    void NextDialog() {
        DialogCounter++;
        if (DialogCounter == 1)
        {
            Text.text = "Harmony University, a Prestigious school with students who excels in music";
        }
        if (DialogCounter == 2)
        {
            Text.text = "Hello choosen One, your passion for music has brought you here";
        }
        if(DialogCounter == 3)
        {
            Text.text = "You are going to save the earth, Now get ready!";
        }
        if (DialogCounter == 4)
        {
            disablecanvas.SetActive(false);
        }
    }
}
