using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    CurrentLoadedScene current;
    [HideInInspector] public string LevelName = string.Empty;
    public static GameManager Instance;
    public bool isPauseLoaded, isInventoryLoaded,isQuestLoaded;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        PlayerPrefs.DeleteAll();
    }
    private void Start()
    {
        current = CurrentLoadedScene.instance;
        isPauseLoaded = false;
        isInventoryLoaded = false;
        isQuestLoaded = false;
        LoadLevelAdditive("ScreenMenu");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&& !isPauseLoaded)
        {
            LoadLevelAdditive("PauseMenu");
            isPauseLoaded = !isPauseLoaded;
        }
        if (Input.GetKeyDown(KeyCode.I) && !isInventoryLoaded)
        {
            isInventoryLoaded = !isInventoryLoaded;
            LoadLevelAdditive("InventoryScene");
        }
        if (Input.GetKeyDown(KeyCode.O) && !isQuestLoaded)
        {
            isQuestLoaded = !isQuestLoaded;
            LoadLevelAdditive("QuestScene");
        }
        if (Input.GetKeyDown(KeyCode.F8))
        {
            UnloadLevel("Stage3_DesolationCity_Scene");
            LoadLevelAsync("Stage1_Forest_Scene");
        }
        if (Input.GetKeyDown(KeyCode.F9))
        {
            UnloadLevel("Stage1_Forest_Scene");
            LoadLevelAsync("Stage2_DireFallCitadel_Scene");
            
        }
        if (Input.GetKeyDown(KeyCode.F10))
        {
            UnloadLevel("Stage2_DireFallCitadel_Scene");
            LoadLevelAsync("Stage3_DesolationCity_Scene");
        }
    }
    public void LoadLevelAsync(string LevelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(LevelName);
    }
    public void UnloadLevel(string LevelName)
    {
        SceneManager.UnloadSceneAsync(LevelName);
    }

    public void LoadLevelAdditive(string LevelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(LevelName, LoadSceneMode.Additive);
    }

    public void LoadCombatSystem()
    {
        AsyncOperation ab = SceneManager.LoadSceneAsync("CombatScene", LoadSceneMode.Additive);
    }

    public void LoadRythmSystem()
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync("RythmUi", LoadSceneMode.Additive);
    }





}
