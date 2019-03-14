using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalScripts : MonoBehaviour {

    Quest quest;

    public int defaultposition;
    private void Start()
    {
        quest = Quest.instance;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            quest.MainQuestProgress(1);
            Destroy(gameObject, 2);
        }
    }
}
