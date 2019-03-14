using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoaderScript : MonoBehaviour {

    public UnityEngine.GameObject LoadingScreen;
    public Slider slider;


    public void LoadLevelAsync(string LevelName)
    {
        LoadAsynchrinously(LevelName);
    }

    IEnumerator LoadAsynchrinously(string LevelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(LevelName);

        LoadingScreen.SetActive(true);
        while (!ao.isDone)
        {
            float progress = Mathf.Clamp01(ao.progress / .9f);
            slider.value = progress;
            yield return null;
        }
    }

}
