using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneManager : MonoBehaviour
{

    CharSelect charSelect;
    EnemyManager enemy;
    [SerializeField] Transform[] Positions;
    [SerializeField] GameObject[] PrefabEnemy;
    [SerializeField] GameObject[] CharacterPrefab;

    GameObject ChPlayer, ChEnemy;
    private void Awake()
    {
        instantiateCharacter();
        InstantiateEnemy();
    }
    public void InstantiateEnemy()
    {
        enemy = GameObject.FindObjectOfType<EnemyManager>();
        if(enemy.enemy == Enemy.goblin) {
            ChEnemy = Instantiate(PrefabEnemy[0], Positions[1].position, Positions[1].rotation);
        }
        if (enemy.enemy == Enemy.troll)
        {
            ChEnemy = Instantiate(PrefabEnemy[1], Positions[1].position, Positions[1].rotation);
        }
        else if (enemy.enemy == Enemy.wolf)
        {
            ChEnemy = Instantiate(PrefabEnemy[2], Positions[1].position, Positions[1].rotation);
        }
    }
    public void instantiateCharacter()
    {
        charSelect = GameObject.FindObjectOfType<CharSelect>();
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
