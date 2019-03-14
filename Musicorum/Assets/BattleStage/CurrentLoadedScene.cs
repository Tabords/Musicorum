using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum CurrentlyLoadedSceneEnum {Stage1,stage2,stage3 }
public class CurrentLoadedScene : MonoBehaviour {
    SavingPlayerPos savingPlayerPos;
    Scene m_Scene;
    string sceneName;
   public static CurrentLoadedScene instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        savingPlayerPos = GameObject.FindObjectOfType<SavingPlayerPos>();
    }
    public CurrentlyLoadedSceneEnum sceneEnum;

    private void Update()
    {
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;

        if (sceneName == "Stage1_Forest_Scene")
        {
            sceneEnum = CurrentlyLoadedSceneEnum.Stage1;
        }
        if (sceneName == "Stage2_DireFallCitadel_Scene")
        {
            sceneEnum = CurrentlyLoadedSceneEnum.stage2;
        }
        if (sceneName == "Stage3_DesolationCity_Scene")
        {
            sceneEnum = CurrentlyLoadedSceneEnum.stage3;
        }
    }
}
