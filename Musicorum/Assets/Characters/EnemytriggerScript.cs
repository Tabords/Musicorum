using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemytriggerScript : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            GameManager.Instance.UnLoadLevel("Stage1_Forest_Scene");
            GameManager.Instance.LoadLevelAsync("BattleStage");
        }
    }
}
