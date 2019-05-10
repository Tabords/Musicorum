using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    CurrentLoadedScene loadedScene;
    CharacterRaycast characterRaycast;
    public CharacterStats_SO[] characterStats;
    GameManager gm;
    public GameObject[] PanelToDisable;
    bool currentstate, isdead;
    public bool battleGuide;
    private void Start()
    {
        loadedScene = CurrentLoadedScene.instance;
        characterRaycast = CharacterRaycast.instance;
        currentstate = true;
        gm = GameManager.Instance;
        isdead = characterRaycast.isDeath;
        PanelToDisable[0].SetActive(currentstate);
        PanelToDisable[1].SetActive(currentstate);
        if (loadedScene.sceneEnum == CurrentlyLoadedSceneEnum.Stage1)
        {
            PanelToDisable[2].SetActive(true);
        }
        else
        {
            PanelToDisable[2].SetActive(false);
        }
    }
    private void Update()
    {
        PanelToDisable[0].SetActive(currentstate);
        PanelToDisable[1].SetActive(currentstate);
        PanelToDisable[2].SetActive(battleGuide);

    }

    public void RythmSystem() //attack
    {
        SongManager.songComplete += SongCompleted;
        gm.LoadRythmSystem();
        if (characterRaycast.isDeath == false)
        {
            currentstate = false;
        }
    }

    public void Flee()
    {
        if (loadedScene.sceneEnum == CurrentlyLoadedSceneEnum.Stage1)
        {
            gm.LoadLevelAsync("Stage1_Forest_Scene");
        }
        if (loadedScene.sceneEnum == CurrentlyLoadedSceneEnum.stage2)
        {
            gm.LoadLevelAsync("Stage2_DireFallCitadel_Scene");
        }
        if (loadedScene.sceneEnum == CurrentlyLoadedSceneEnum.stage3)
        {
            gm.LoadLevelAsync("Stage3_DesolationCity_Scene");
        }
    }
    public void Potion() // access inventory later
    {
        if (characterStats[0].currentHealth <= characterStats[0].maxHealth || characterStats[1].currentHealth <= characterStats[1].maxHealth)
        {
            if (gm.PotionCount > 0)
            {
                gm.UsePotion(1);
                characterRaycast.character.ApplyHealth(50);
            }
        }
    }
    void SongCompleted()
    {
        if (isdead == true)
        {
            currentstate = false;
        }
        else
            currentstate = true;
        SongManager.songComplete -= SongCompleted;
    }
    public void BattleGuideTurn(bool bGuide)
    {
        battleGuide = bGuide;
    }
}
