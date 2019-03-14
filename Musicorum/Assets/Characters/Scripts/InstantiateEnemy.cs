using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemy : MonoBehaviour {
    [Header("Enemy Spawn Points")]
    [SerializeField] Transform[] EnemyPos;

    [Header("Enemy prefabs")]
    [SerializeField] UnityEngine.GameObject[] EnemyPrefab;
    int EnemySpawnPointRand;

    [Header("Type of Enemies")]
    public int EnemyType;

    [Header("Enemy Boss Prefab")]
    [SerializeField] UnityEngine.GameObject BossPrefab;

    [Header("Boss Spawn Positions")]
    [SerializeField] Transform[] EnemyBossPositions;


    int EnemyTypeRand;
    UnityEngine.GameObject enemy;

    int enemyposLenght;
    // Use this for initialization
    void Start () {
        StartCoroutine(Enemy());
        StartCoroutine(BossCall());
    }
	// Update is called once per frame
    IEnumerator Enemy()
    {
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(4f);
            EnemySpawnPointRand = Random.Range(0, EnemyPos.Length);
            EnemyTypeRand = Random.Range(0, EnemyPrefab.Length);
            enemy = Instantiate(EnemyPrefab[EnemyTypeRand], EnemyPos[EnemySpawnPointRand].transform.position, EnemyPos[EnemySpawnPointRand].transform.rotation);
        }
    }
    IEnumerator BossCall()
    {
        int random = Random.Range(0, EnemyBossPositions.Length);    
        Instantiate(BossPrefab, EnemyBossPositions[random].position, EnemyBossPositions[random].rotation);
        yield return null;
    }

    private void OnDestroy()
    {
        Destroy(enemy);
    }
}
