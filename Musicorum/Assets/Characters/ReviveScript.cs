using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReviveScript : MonoBehaviour {

    Quest quest;
    public CharacterStats_SO[] charstats;
    [SerializeField] GameObject[] Conditions;

	// Use this for initialization
	void Start () {
        quest = Quest.instance;
    }
    private void Update()
    {
        if (charstats[0].currentHealth <= 0 || charstats[1].currentHealth <= 0)
        {
            Conditions[1].SetActive(true);
        }
    }
    public void RevivePlayer()
    {
        quest.ResetCurrentProgress();
        charstats[0].ApplyHealth(charstats[0].maxHealth /2 - 20);
        charstats[1].ApplyHealth(charstats[1].maxHealth /2 - 20);
    }
    
}
