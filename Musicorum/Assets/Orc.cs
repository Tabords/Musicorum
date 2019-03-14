using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : MonoBehaviour {

    public delegate void OrcKingDied();
    public event OrcKingDied orcKingDied;
    [SerializeField]Animator animator;
    EnemyBehavior enemyBehavior;
    Quest quest;
    public int CHealth;
    public int MHealth;
    public int CDamage;
    public int Damage;
    public bool isAttack;
    AnimatorClipInfo clipInfo;
    private void Start()
    {
        enemyBehavior = new EnemyBehavior(MHealth, CHealth, Damage, CDamage);
        quest = Quest.instance;
    }
    private void Update()
    {
        Debug.Log(CHealth);
        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Attack 1"))
        {
            Debug.Log("Attack Anim is Done");
            Attack(false);
        }
    }

    public void Attack(bool attack)
    {
        isAttack = attack;
        Debug.Log("called");
        animator.SetBool("Attack 1", attack);
    }
    public void TakeDamage(int Take)
    {
        CHealth -= Take;
        if (CHealth <= 0)
        {
            animator.SetBool("Death", true);
            quest.QuestProgress(1);
            if (gameObject.tag == "OrcKing")
            {
                if (orcKingDied != null)
                {
                    orcKingDied();
                }
            }
        }
    }
}
