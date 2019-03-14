using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior
{
   int MaxHealth;
   int CurrentHealth;
   int Damage;
   int CurrentDamage;

    public EnemyBehavior(int maxHealth, int currentHealth, int damage, int currentDamage)
    {
        this.MaxHealth = maxHealth;
        this.CurrentHealth = currentHealth;
        this.Damage = damage;
        this.CurrentDamage = currentDamage;
    }
   
}
