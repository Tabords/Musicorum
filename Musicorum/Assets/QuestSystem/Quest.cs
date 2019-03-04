using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Quest : MonoBehaviour {

    GameManager gm;
    [Header("List Of Quest")]
    public Quest_SO quest;
    [SerializeField] Text Description,Required;
    int CurrentProgress;

    public delegate void CurrenQuest();
    public event CurrenQuest Cquest;

    private void Start()
    {
        gm = GameManager.Instance;
        Description.text = quest.Description;
        Required .text =CurrentProgress.ToString() +"/" + quest.required.ToString();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && gm.isQuestLoaded == true)
        {
            gm.isQuestLoaded = false;
            UnloadLevel();
        }
    }
    public void QuestProgress()
    {
        if (Cquest != null)
        {
            Cquest();
        }
    }
     void UnloadLevel()
    {
        gm.UnloadLevel("QuestScene");
    }
}
