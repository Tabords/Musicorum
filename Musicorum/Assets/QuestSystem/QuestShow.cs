using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestShow : MonoBehaviour {
    [SerializeField] Text SideQuestDescription, SideQuestRequired, MainQuestDescription,MainQuestRequired;
    Quest quest;
    GameManager gm;
    // Use this for initialization
    void Start () {
        quest = Quest.instance;
        gm = GameManager.Instance;
	}
    private void Update()
    {
        SideQuestDescription.text = quest.ListQuest[quest.currentQuest].Description;
        SideQuestRequired.text = quest.CurrentProgress.ToString() + "/" + quest.ListQuest[quest.currentQuest].required.ToString();
        MainQuestDescription.text = quest.MainQuest.Description;
        MainQuestRequired.text = quest.MainProgress.ToString() + "/" + quest.MainQuest.required.ToString();
        if (Input.GetKeyDown(KeyCode.O)&&gm.isQuestLoaded == true)
        {
            gm.isQuestLoaded = false;   
            UnloadLevel();
        }
    }
    void UnloadLevel()
    {
        gm.UnloadLevel("QuestScene");
    }
}
