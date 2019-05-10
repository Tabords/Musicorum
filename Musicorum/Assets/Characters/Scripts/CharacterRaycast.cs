using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRaycast : MonoBehaviour
{
    [SerializeField] Animator animator;
    public static CharacterRaycast instance;
    RaycastHit hit;
   public CharacterStats character;
    public bool isDeath, isAttack, isHit;
    CombatManager cm;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(gameObject);
    }
    private void Start()
    {
        character = GetComponent<CharacterStats>();
        cm = GameObject.FindObjectOfType<CombatManager>();
    }
    private void FixedUpdate()
    {
        animator.SetBool("isAttack", isAttack);
        animator.SetBool("isDead", isDeath);
        animator.SetBool("isDamage", isHit);
        if (Physics.Raycast(transform.position, transform.forward, out hit, 50))
        {
            if (hit.collider.tag == "OrcDagger" || hit.collider.tag == "OrcSpear" || hit.collider.tag == "OrcKing"|| hit.collider.tag == "WereWolf"|| hit.collider.tag == "BlackWolf" || hit.collider.tag == "WhiteWolf" || hit.collider.tag == "MiniBot" || hit.collider.tag == "MegaBot")
            {
                Orc orc = hit.collider.GetComponent<Orc>();
                if (orc.isAttack == true) // player action
                {
                    if (isDeath == false)
                    {
                        isHit = true;
                        
                        animator.SetBool("isDamage", isHit);
                        character.characterDefinition.TakeDamage(orc.CDamage);
                        orc.isAttack = false;
                    }
                    if(isDeath)
                    {
                        cm.PanelToDisable[3].SetActive(false);
                    }
                }
                if (isAttack == true)
                { // enemy action
                    orc.TakeDamage(character.characterDefinition.currentDamage);
                    orc.Hit(true);
                    isAttack = false;
                }
                isHit = false;
                isAttack = false;
            }
        }
    }
}
