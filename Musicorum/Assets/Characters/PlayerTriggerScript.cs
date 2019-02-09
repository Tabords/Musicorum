using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Enemy { none, goblin, troll, wolf } // proceeds later 
public class PlayerTriggerScript : MonoBehaviour
{
    public static Enemy enemy;
    public delegate void BattleSceneEnemy();
    public static event BattleSceneEnemy battleScene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goblin")
        {
            Debug.Log(other.gameObject + "collides to player");
            enemy = Enemy.goblin;
            if (battleScene != null)
            {
                Debug.Log("collide with goblin");
                GameManager.Instance.UnLoadLevel("Stage1_Forest_Scene");
                //save scene
                //loading screen
                GameManager.Instance.LoadLevelAsync("BattleStage");
                battleScene();
            }
        }
        else if (other.tag == "Troll")
        {
            enemy = Enemy.troll;
            if (battleScene != null)
            {
                GotoScene();
            }
        }
        else if (other.tag == "Wolf")
        {
            enemy = Enemy.wolf;
            if (battleScene != null)
            {
                GotoScene();
            }
        }
    }

    void GotoScene()
    {
        

    }
}
