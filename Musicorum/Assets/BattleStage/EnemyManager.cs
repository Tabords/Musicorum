using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Enemy { none, goblin, troll, wolf } // proceeds later 
public class EnemyManager : MonoBehaviour {

    public Enemy enemy;

    public delegate void EnemyCollided();
    public delegate void BattleSceneEnemy();
    public event BattleSceneEnemy battleScene;

    public delegate void TriggerSaveData();
    public static event TriggerSaveData triggerSaveData;
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
