using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHealth : MonoBehaviour {

    Slider healthbar;
    [SerializeField] Orc orc;
    // Use this for initialization
	void Start () {
        orc = GetComponent<Orc>();
        healthbar = GetComponentInChildren<Slider>();
        healthbar.maxValue = orc.MHealth;
        healthbar.minValue = 0;
	}
	// Update is called once per frame
	void Update () {
        healthbar.value = orc.CHealth;
	}
}
