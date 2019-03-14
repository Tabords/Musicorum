using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRaycast : MonoBehaviour {
    [SerializeField]Animator animator;

    CharacterStats character;
    public bool isDeath, isAttack;
    private void Start()
    {
        character = GetComponent<CharacterStats>();
    }
    private void FixedUpdate()
    {
        animator.SetBool("Attack 1", isAttack);
        animator.SetBool("Death", isDeath);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 50))
        {
            if (hit.collider.tag == "OrcDagger")
            {
                Orc orc = hit.collider.GetComponent<Orc>();
                Debug.Log("Hits Orc Dagger");
                if(isAttack == true) {
                    orc.SendMessage("TakeDamage", character.characterDefinition.currentDamage);
                    if (orc.isAttack == true)
                    {
                        character.characterDefinition.TakeDamage(orc.CDamage);
                    }
                    isAttack = false;
                }
            }
            if (hit.collider.tag == "OrcSpear")
            {
                Orc orc = hit.collider.GetComponent<Orc>();
                if (isAttack == true)
                {
                    orc.SendMessage("TakeDamage", character.characterDefinition.currentDamage);
                    if (orc.isAttack== true)
                    {
                        character.characterDefinition.TakeDamage(orc.CDamage);
                    }
                    isAttack = false;
                }
            }
            if (hit.collider.tag == "OrcKing")
            {
                Orc orc = hit.collider.GetComponent<Orc>();
                if (isAttack == true)
                {
                    orc.SendMessage("TakeDamage", character.characterDefinition.currentDamage);
                    if (orc.isAttack == true)
                    {
                        character.characterDefinition.TakeDamage(orc.CDamage);
                    }
                    isAttack = false;
                }
            }
            if (hit.collider.tag == "WereWolf")
            {
                wolf wolf = hit.collider.GetComponent<wolf>();
                if (isAttack == true)
                {
                    Debug.Log("Hits WereWolf");
                    wolf.SendMessage("TakeDamage", character.characterDefinition.currentDamage);
                    if (wolf.isAttack == true)
                    {
                        character.characterDefinition.TakeDamage(wolf.CDamage);
                    }
                    isAttack = false;
                }
            }
            if (hit.collider.tag == "BlackWolf")
            {
                if (isAttack == true)
                {
                    Debug.Log("Hits Orc King");
                    wolf wolf = hit.collider.GetComponent<wolf>();
                    wolf.SendMessage("TakeDamage", character.characterDefinition.currentDamage);
                    if (wolf.isAttack == true)
                    {
                        character.characterDefinition.TakeDamage(wolf.CDamage);
                    }
                    isAttack = false;
                }
            }
            if (hit.collider.tag == "WhiteWolf")
            {
                wolf wolf = hit.collider.GetComponent<wolf>();
                if (isAttack == true)
                {
                    Debug.Log("HIts Whitewolf");
                    wolf.SendMessage("TakeDamage", character.characterDefinition.currentDamage);
                    if (wolf.isAttack == true)
                    {
                        character.characterDefinition.TakeDamage(wolf.CDamage);
                    }
                    isAttack = false;
                }
            }
        }
    }
}
