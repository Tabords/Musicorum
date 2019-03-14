using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RythmUnloader : MonoBehaviour {

    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.Instance;

        SongManager.songComplete += UnloadRythm;
    }

    void UnloadRythm()
    {
        gameManager.UnloadLevel("RythmUi");
    }
}
