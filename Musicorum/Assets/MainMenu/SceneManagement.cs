using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagement : MonoBehaviour {

    public void Loadscene(string SceneName)
    {
        GameManager.Instance.LoadLevelAsync(SceneName);
    }
    public void UnLoadScene(string UnloadSceneName)
    {
        GameManager.Instance.UnLoadLevel(UnloadSceneName);
    }
}
