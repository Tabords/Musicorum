using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum CurrentlyLoadedSceneEnum {Stage1,stage2,stage3 }
public class CurrentLoadedScene : MonoBehaviour {
    Scene m_Scene;
    string sceneName;
    public static CurrentLoadedScene instance;
    RemovePlayerPreprefs removePlayerPreprefs;
    public int StageCounter1, StageCounter2, StageCounter3;
    #region Singleton
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
    #endregion 
    private void Start()
    {
        StageCounter1 = StageCounter2 = StageCounter3 = 0;
        removePlayerPreprefs = gameObject.GetComponent<RemovePlayerPreprefs>();
    }
    public CurrentlyLoadedSceneEnum sceneEnum;

    private void Update()
    {

        Debug.Log("stage1Counter: " + StageCounter1 + "StageCounter2: " + StageCounter2 + " StageCounter3: " + StageCounter3);
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        if (sceneName == "Stage1_Forest_Scene")
        {
            sceneEnum = CurrentlyLoadedSceneEnum.Stage1;
        }
        if (sceneName == "Stage2_DireFallCitadel_Scene")
        {
            if (StageCounter2 == 0)
            {
                StageCounter2++;
                sceneEnum = CurrentlyLoadedSceneEnum.stage2;
            }
        }
        if (sceneName == "Stage3_DesolationCity_Scene")
        {
            if(StageCounter3 == 0) {
                StageCounter3++;
                sceneEnum = CurrentlyLoadedSceneEnum.stage3;
            }
       
        }
    }
}
