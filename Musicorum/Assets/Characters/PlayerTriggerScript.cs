using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerTriggerScript : MonoBehaviour
{
    EnemyManager Enemyselected;
    SavingPlayerPos savingPlayerPos;
    private void OnTriggerEnter(Collider other)
    {
        savingPlayerPos = GameObject.FindObjectOfType<SavingPlayerPos>();
        Enemyselected = GameObject.FindObjectOfType<EnemyManager>();
        if (other.tag == "Goblin")
        {
            Destroy(other.gameObject);
            Enemyselected.enemy = Enemy.goblin;
            GameManager.Instance.LoadLevelAsync("BattleStage");
            LoadRythm();
        }
        else if (other.gameObject.tag == "Troll")
        {
            Enemyselected.enemy = Enemy.troll;
            GameManager.Instance.LoadLevelAsync("BattleStage");
            LoadRythm();
        }
        else if (other.gameObject.tag == "Wolf")
        {
            Enemyselected.enemy = Enemy.wolf;
            GameManager.Instance.LoadLevelAsync("BattleStage");
            LoadRythm();
        }

    }

    void LoadRythm()
    {
        GameManager.Instance.LoadCombatSystem();
    }
}
