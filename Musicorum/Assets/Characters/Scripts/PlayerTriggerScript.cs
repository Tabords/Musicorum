﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerTriggerScript : MonoBehaviour
{
    EnemyManager Enemyselected;
    SavingPlayerPos savingPlayerPos;
    LoaderScript loaderScript;
    private void Start()
    {
        loaderScript = GameObject.FindObjectOfType<LoaderScript>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Enemyselected = UnityEngine.GameObject.FindObjectOfType<EnemyManager>();
        Debug.Log("thisthis");
        if (other.tag == "OrcDagger")
        {
            Debug.Log("OrcDagger collide");
            Destroy(other.gameObject);
            Enemyselected.enemy = Enemy.OrcDagger;
            loaderScript.LoadLevelAsync("BattleStage");
            LoadCombat();
        }
        else if (other.gameObject.tag == "OrcSpear")
        {
            Destroy(other.gameObject);
            Enemyselected.enemy = Enemy.OrcSpear;
            loaderScript.LoadLevelAsync("BattleStage");
            LoadCombat();
        }
        else if (other.gameObject.tag == "OrcKing")
        {
            Destroy(other.gameObject);
            Enemyselected.enemy = Enemy.OrcKing;
            GameManager.Instance.LoadLevelAsync("BattleStage");
            LoadCombat();
        }
        else if (other.gameObject.tag == "WhiteWolf")
        {
            Destroy(other.gameObject);
            Enemyselected.enemy = Enemy.WhiteWolf;
            GameManager.Instance.LoadLevelAsync("Stage2_Battle_Scene");
            LoadCombat();
        }
        else if (other.gameObject.tag == "WereWolf")
        {
            Destroy(other.gameObject);
            Enemyselected.enemy = Enemy.WereWolf;
            GameManager.Instance.LoadLevelAsync("Stage2_Battle_Scene");
            LoadCombat();
        }
        else if (other.gameObject.tag == "BlackWolf")
        {
            Destroy(other.gameObject);
            Enemyselected.enemy = Enemy.BlackWolf;
            GameManager.Instance.LoadLevelAsync("Stage2_Battle_Scene");
            LoadCombat();
        }

        else if (other.gameObject.tag == "MiniBot")
        {
            Destroy(other.gameObject);
            Enemyselected.enemy = Enemy.MiniBot;
            GameManager.Instance.LoadLevelAsync("Stage3_BattleScene");
            LoadCombat();
        }
        else if (other.gameObject.tag == "MegaBot")
        {
            Destroy(other.gameObject);
            Enemyselected.enemy = Enemy.MegaBot;
            GameManager.Instance.LoadLevelAsync("Stage3_BattleScene");
            LoadCombat();
        }
    }

    void LoadCombat()
    {
        GameManager.Instance.LoadCombatSystem();
    }
}
