using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{


    public static SceneManagement instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void LoadLevelAsync(string LevelName)
    {
        StartCoroutine(LoadAsynchrinously(LevelName));
    }
    public void LoadLevelAdditive(string SceneName)
    {
        GameManager.Instance.LoadLevelAsync(SceneName);
    }
    IEnumerator LoadAsynchrinously(string LevelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(LevelName);

        //LoadingScreen.SetActive(true);
        while (!ao.isDone)
        {
            float progress = Mathf.Clamp01(ao.progress / .9f);
         //   slider.value = progress;
            yield return null;
        }
    }
}

