using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "new Stats", menuName = "Character/Stats")]
public class CharacterStats_SO : ScriptableObject
{
    [System.Serializable]
    public class CharlevelUps
    {
        public int MaxHealth;
        public int baseDamage;
        public int baseAgility;
        public int baseResistance;
        public int baseExperience;

    }
    public bool setManually = false;
    public bool saveDataOnClose = false;

    public int maxHealth = 0;
    public int currentHealth = 0;

    public int baseDamage = 0;
    public int currentDamage = 0;

    public int baseResistance = 0;
    public int currentResistance = 0;

    public int baseAgility = 0;
    public int currentAgility = 0;

    public int baseExperience = 0;
    public int CurrentExperience = 0;
    public int charLevel = 0;


    public CharlevelUps[] charlevelUps;


    public void ApplyHealth(int healthAmount)
    {
        if ((currentHealth + maxHealth) > maxHealth)
        {
            currentHealth = maxHealth;
        }
        else
        {
            currentHealth += healthAmount;
        }
    }

    public void ExperienceUp(int ExpUp)
    {
        CurrentExperience += ExpUp;

        if (CurrentExperience >= baseExperience)
        {
            CurrentExperience = 0;
            LevelUp();
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Death();
        }
       
    }
    private void Death()
    {
        //death animation
        //death screen
        Debug.Log("Dead");

    }

    private void LevelUp()
    {
        charLevel += 1;
        //level up particle
            
        maxHealth = charlevelUps[charLevel - 1].MaxHealth;
        baseDamage = charlevelUps[charLevel - 1].baseDamage;
        baseAgility= charlevelUps[charLevel - 1].baseAgility;
        baseResistance = charlevelUps[charLevel - 1].baseResistance;
        baseExperience= charlevelUps[charLevel - 1].baseExperience;
    }

    public void saveCharacterDAta()
    {
        saveDataOnClose = true;
        EditorUtility.SetDirty(this);
    }


}
