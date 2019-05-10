using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPersistence : MonoBehaviour
{

    Slider healthBar;
    [SerializeField]CharacterStats characterStats;
    private void Start()
    {
        characterStats = GetComponent<CharacterStats>();
        healthBar = GetComponentInChildren<Slider>();
        healthBar.maxValue = characterStats.characterDefinition.maxHealth;
        healthBar.minValue = 0;
    }
    private void Update()
    {
        healthBar.value = characterStats.characterDefinition.currentHealth;
    }
}
