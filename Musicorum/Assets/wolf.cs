using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolf : MonoBehaviour {
    [SerializeField] Animator animator;
    EnemyBehavior enemyBehavior;
    Quest quest;
    public int CHealth;
    public int MHealth;
    public int CDamage;
    public int Damage;
    public bool isAttack;
    bool IsDamage;
    bool isDead;
    // Use this for initialization
    void Start () {
        enemyBehavior = new EnemyBehavior(MHealth, CHealth, Damage, CDamage);
        quest = Quest.instance;
    }
    private void Update()
    {
        animator.SetBool("isAttack", isAttack);
        animator.SetBool("isDead", isDead);
        animator.SetBool("isDamage", IsDamage);

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Hit"))
        {
            IsDamage = false;
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            isAttack = false;
        }
    }
    // Update is called once per frame

    public void Attack(bool attack)
    {
        if (isDead == false)
        {
            isAttack = attack;
        }
    }
    public void TakeDamage(int Take) // value that the enemy receives 
    {
        CHealth -= Take;

        if (CHealth <= 0)
        {
            isDead = true;
            quest.QuestProgress(1);         // add progress to the quest +1 
        }
    }
    public void Hit(bool isDamage) // calls when player attacks and enemy taking damage
    {
        if (isDead == false)
            IsDamage = isDamage;
    }
}
