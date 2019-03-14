using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageScript : MonoBehaviour {

    [SerializeField] Animator animator;

    bool isAttack, isDead;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        animator.SetBool("Attack 1", isAttack);
        animator.SetBool("Death", isDead);
    }

   public void AttackAnim(bool attack)
    {
        isAttack = attack;
    }
    
}
