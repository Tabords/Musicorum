using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemy : MonoBehaviour {

    [SerializeField] Transform[] EnemyPos;
    [SerializeField] GameObject[] EnemyPrefab;
    int rand;
    GameObject enemy;
    // Use this for initialization
    void Start () {
        StartCoroutine(Enemy());
    }
	
	// Update is called once per frame
    IEnumerator Enemy()
    {

        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(4f);
            rand = Random.Range(0, 6);
             enemy = Instantiate(EnemyPrefab[0], EnemyPos[rand].transform.position, EnemyPos[rand].transform.rotation);
        }
    }

    private void OnDestroy()
    {
        Destroy(enemy);
    }
}
