using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {
    public string LevelName;
    public string CUrrentLevel;
    GameManager gm;
    private void Start()
    {
        gm = GameManager.Instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gm.UnloadLevel(CUrrentLevel);
            gm.LoadLevelAsync(LevelName);
        }
    }
}
