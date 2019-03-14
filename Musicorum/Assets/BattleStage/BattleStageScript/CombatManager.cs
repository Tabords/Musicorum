using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    CurrentLoadedScene loadedScene;
    private void Start()
    {
        loadedScene = CurrentLoadedScene.instance;     
    }

    public void RythmSystem()
    {
        GameManager.Instance.LoadRythmSystem();
    }

    public void Flee()
    {
        if(loadedScene.sceneEnum == CurrentlyLoadedSceneEnum.Stage1)
        { 
        GameManager.Instance.LoadLevelAsync("Stage1_Forest_Scene");
        }
        if (loadedScene.sceneEnum == CurrentlyLoadedSceneEnum.stage2)
        {
            GameManager.Instance.LoadLevelAsync("Stage2_DireFallCitadel_Scene");
        }
        if (loadedScene.sceneEnum == CurrentlyLoadedSceneEnum.stage3)
        {
            GameManager.Instance.LoadLevelAsync("Stage3_DesolationCity_Scene");
        }
    }
    public void Potion() // access inventory later
    {

    }

    public void Defend()
    {


    }

}
