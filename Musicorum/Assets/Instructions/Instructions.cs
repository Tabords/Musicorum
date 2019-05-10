using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    GameManager gm;
    public static Instructions instance;
    CurrentLoadedScene loadedScene;
    bool loadInstruction;
    private void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
        gm = GameManager.Instance;
        loadedScene = CurrentLoadedScene.instance;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gm.LoadLevelAdditive("InstructionScene");
            loadInstruction = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Unload Instructions");
            gm.UnloadLevel("InstructionScene");
            Destroy(gameObject);

        }
    }
}
