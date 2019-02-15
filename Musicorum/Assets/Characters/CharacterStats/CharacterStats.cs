﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {

   public  CharacterStats_SO characterDefinition;

    private void Start()
    {
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

      //  PlayerTriggerScript.triggerSaveData += SaveData;
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
    //    PlayerTriggerScript.triggerSaveData -= SaveData;
    }
}
