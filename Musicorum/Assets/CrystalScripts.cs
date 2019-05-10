using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalScripts : MonoBehaviour {

    Quest quest;
    [SerializeField]Animator animator;
    private void Start()
    {
        quest = Quest.instance;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("isDead", true);
            quest.MainQuestProgress(1);
            Destroy(gameObject, 2);
        }
    }
}
