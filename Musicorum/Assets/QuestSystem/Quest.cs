using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public enum QuestRank{none,Stage1Q,Stage2Q,Stage3Q }
public class Quest : MonoBehaviour {
    public QuestRank questRank;
    GameManager gm;
    [Header("List Of SideQuest")]
    public Quest_SO[] ListQuest;

    [Header("Main Quest")]
    public Quest_SO MainQuest;
    public int CurrentProgress;
    public  int MainProgress;
    public static Quest instance;
    public int currentQuest;
    #region Singleton
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    #endregion
    private void Start()
    {
        gm = GameManager.Instance;
    }
    private void Update()
    {
            switch (questRank)
            {
                case QuestRank.Stage1Q:
                    currentQuest = 0;
                    break;
                case QuestRank.Stage2Q:
                    currentQuest = 1;
                    break;
                case QuestRank.Stage3Q:
                    currentQuest = 2;
                    break;
            }
        Debug.Log("currentProgres" + CurrentProgress);

        if (Input.GetKeyDown(KeyCode.F11))
        {
            QuestProgress(1);
        }
        if (Input.GetKeyDown(KeyCode.F12))
        {
            MainQuestProgress(1);
        }
    }
    public void QuestProgress(int progress)
    {
        CurrentProgress += progress;
        if (progress >= ListQuest[currentQuest].required)
        {
            CurrentProgress = 0;
        }
    }
    public void MainQuestProgress(int progress)
    {
        MainProgress += progress;
    }
    public void ResetCurrentProgress()
    {
        CurrentProgress = 0;
    }
  
}
