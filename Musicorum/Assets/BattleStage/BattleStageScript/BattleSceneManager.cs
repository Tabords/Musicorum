using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneManager : MonoBehaviour
{

    CharSelect charSelect;
    EnemyManager enemy;
    [SerializeField] Transform[] Positions;
    [SerializeField] UnityEngine.GameObject[] PrefabEnemy;
    [SerializeField] UnityEngine.GameObject[] CharacterPrefab;

    UnityEngine.GameObject ChPlayer, ChEnemy;
    private void Awake()
    {
        instantiateCharacter();
        InstantiateEnemy();
    }
    public void InstantiateEnemy()
    {
        enemy = UnityEngine.GameObject.FindObjectOfType<EnemyManager>();
        if(enemy.enemy == Enemy.OrcDagger) {
            ChEnemy = Instantiate(PrefabEnemy[0], Positions[1].position, Positions[1].rotation);
        }
        if (enemy.enemy == Enemy.OrcSpear)
        {
            ChEnemy = Instantiate(PrefabEnemy[1], Positions[1].position, Positions[1].rotation);
        }
        if (enemy.enemy == Enemy.WhiteWolf)
        {
            ChEnemy = Instantiate(PrefabEnemy[2], Positions[1].position, Positions[1].rotation);
        }
        if (enemy.enemy == Enemy.MiniBot)
        {
            ChEnemy = Instantiate(PrefabEnemy[3], Positions[1].position, Positions[1].rotation);
        }
        if (enemy.enemy == Enemy.OrcKing)
        {
            ChEnemy = Instantiate(PrefabEnemy[4], Positions[1].position, Positions[1].rotation);
        }
        if (enemy.enemy == Enemy.WereWolf)
        {
            ChEnemy = Instantiate(PrefabEnemy[5], Positions[1].position, Positions[1].rotation);
        }
        if (enemy.enemy == Enemy.MegaBot)
        {
            ChEnemy = Instantiate(PrefabEnemy[6], Positions[1].position, Positions[1].rotation);
        }
        if (enemy.enemy == Enemy.BlackWolf)
        {
            ChEnemy = Instantiate(PrefabEnemy[7], Positions[1].position, Positions[1].rotation);
        }
    }
    public void instantiateCharacter()
    {
        charSelect = UnityEngine.GameObject.FindObjectOfType<CharSelect>();
        if (charSelect.Charenum == choices.Kazu)
        {
            ChPlayer =  Instantiate(CharacterPrefab[0], Positions[0].position, Positions[0].rotation);
        }
        else if (charSelect.Charenum == choices.sophia)
        {
            ChPlayer = Instantiate(CharacterPrefab[1], Positions[0].position, Positions[0].rotation);
        }
    }
    private void OnDestroy()
    {
        Destroy(ChPlayer);
        Destroy(ChEnemy);
    }
}
