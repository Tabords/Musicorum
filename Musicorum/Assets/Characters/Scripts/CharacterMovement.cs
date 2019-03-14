using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    [SerializeField] Animator CharacterAnimator;
	// Update is called once per frame
	void Update () {
        float fb = Input.GetAxis("Vertical");
        float lr = Input.GetAxis("Horizontal");
        CharacterAnimator.SetFloat("FB", fb);
	}
}
