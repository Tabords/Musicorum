using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneManager : MonoBehaviour
{

    [SerializeField] Transform[] Positions;
    [SerializeField] GameObject[] PrefabEnemy;
    private void Start()
    {
        PlayerTriggerScript.battleScene += InstantiateEnemy;


    }
    public void InstantiateEnemy()
    {
        if (PlayerTriggerScript.enemy == Enemy.goblin)
        {
            Debug.Log(PlayerTriggerScript.enemy);
            Instantiate(PrefabEnemy[0], Positions[1].position, Positions[1].rotation);
        }
        else if (PlayerTriggerScript.enemy == Enemy.troll)
        {
            Instantiate(PrefabEnemy[1], Positions[1].position, Positions[1].rotation);
        }
        else if (PlayerTriggerScript.enemy == Enemy.wolf)
        {
            Instantiate(PrefabEnemy[2], Positions[1].position, Positions[1].rotation);
        }
        PlayerTriggerScript.battleScene -= InstantiateEnemy;
    }
}
