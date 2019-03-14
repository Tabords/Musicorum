using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnLightEnter : MonoBehaviour {
    Quest quest;
    GameManager gm;

    public QuestRank lightQuest;
    private void Start()
    {
        gm = GameManager.Instance;
        quest = Quest.instance;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            quest.questRank = lightQuest;
            if(quest.questRank == QuestRank.Stage1Q) { 
            gm.LoadLevelAdditive("LightCutScene");
            }
            if (quest.questRank == QuestRank.Stage2Q)
            {
                gm.LoadLevelAdditive("LightCutScene");
            }
            if (quest.questRank == QuestRank.Stage3Q)
            {
                gm.LoadLevelAdditive("LightCutScene");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        gm.UnloadLevel("LightCutScene");
    }
}
