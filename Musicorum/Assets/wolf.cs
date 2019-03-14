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
    // Use this for initialization
    void Start () {
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
    // Update is called once per frame

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
            animator.SetBool("isDead", true);
            quest.QuestProgress(1);
            if (gameObject.tag == "WereWolf")
            {

            }
        }
    }
}
