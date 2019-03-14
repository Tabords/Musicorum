using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{

    [SerializeField] Animator animator;
    EnemyBehavior enemyBehavior;
    Quest quest;
    public int CHealth;
    public int MHealth;
    public int CDamage;
    public int Damage;
    // Use this for initialization
    void Start()
    {
        enemyBehavior = new EnemyBehavior(MHealth, CHealth, Damage, CDamage);
        quest = Quest.instance;
    }
    public void Attack(bool attack)
    {
        Debug.Log("called");
        animator.SetBool("isAttack", attack);
    }
    public void TakeDamage(int Take)
    {
        CHealth -= Take;
        if (CHealth <= 0)
        {
            animator.SetBool("isDeath", true);
            quest.QuestProgress(1);
            if (gameObject.tag == "OrcKing")
            {

            }
        }
    }
}
