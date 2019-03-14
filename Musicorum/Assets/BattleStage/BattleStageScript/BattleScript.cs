using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleScript : MonoBehaviour {
    [SerializeField] Animator animator;
    Slider gauge;
    ResetGauge resetGauge;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        resetGauge = UnityEngine.GameObject.FindObjectOfType<ResetGauge>();
    }
    // Update is called once per frame
    void Update()
    {
         
    }
  
}
