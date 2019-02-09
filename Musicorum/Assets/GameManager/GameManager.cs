using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject dummycam;
    [SerializeField] GameObject canvas;
    [HideInInspector] public string LevelName = string.Empty;
    bool isAnyPress;
    public static GameManager Instance;
    #region Singleton
    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
           
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion
    void Start()
    {
        isAnyPress = false;
    }
    public void LoadLevelAsync(string LevelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(LevelName, LoadSceneMode.Additive);
    }
    public void UnLoadLevel(string LevelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(LevelName);
    }
    private void Update()
    {
        int loadedScene = SceneManager.sceneCountInBuildSettings;
        if (!isAnyPress)
        {
            if (Input.anyKeyDown)
            {
                WhenPressAny();
            }
        }
        
    }

    public void WhenPressAny()
    {
        LoadLevelAsync("MainMenuScene");
        dummycam.SetActive(false);
        canvas.SetActive(false);
        isAnyPress = true;
    }
}
