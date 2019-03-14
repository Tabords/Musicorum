using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {
    Animator animator;
   public  CharacterStats_SO characterDefinition;
    private void Start()
    {
        animator = GetComponent<Animator>();
        if (!characterDefinition.setManually)
        {
            characterDefinition.maxHealth = 100;
            characterDefinition.currentHealth = 100;
            characterDefinition.baseDamage = 10;
            characterDefinition.currentDamage = characterDefinition.baseDamage;
            characterDefinition.baseAgility = 30;
            characterDefinition.currentAgility = 30;
            characterDefinition.baseResistance = 0;
            characterDefinition.currentResistance = 0;
            characterDefinition.CurrentExperience = 0;
            characterDefinition.charLevel = 1;
        }
    }
    public void ApplyHealth(int healthAmount)
    {
        characterDefinition.ApplyHealth(healthAmount);
    }
    public void ExperienceUp(int CurrentExp) //call method when player kills enemy
    {
        characterDefinition.ExperienceUp(CurrentExp);
    }
    public void Damagetake(int amount)
    {
        characterDefinition.TakeDamage(amount);
    }
    public void SaveData()
    {
        characterDefinition.saveCharacterDAta();
    }
    public void Update()
    {
        if(characterDefinition.currentHealth <= 0)
        {
            Debug.Log("asda");
            animator.SetBool("Death", true);
        }
    }
}
