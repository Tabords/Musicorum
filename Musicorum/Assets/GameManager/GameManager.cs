using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    EnemyManager enmyManager;

    [SerializeField] Camera DummyCamera;
    [HideInInspector] public string LevelName = string.Empty;
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
     void Update()
    {
        cheatSheet();
    }

    public void LoadLevelAsync(string LevelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(LevelName);
        DummyCamera.gameObject.SetActive(false);
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


    void cheatSheet()
    {
        enmyManager = FindObjectOfType<EnemyManager>();
        if (Input.GetKeyDown(KeyCode.F2))
        {
            enmyManager.enemy = Enemy.goblin;
            AsyncOperation ab = SceneManager.LoadSceneAsync("BattleStage", LoadSceneMode.Additive);
            LoadCombatSystem();
        }
    }


}
