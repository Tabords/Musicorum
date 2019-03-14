using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcKingDied : MonoBehaviour
{
    Animator animator;
    Orc orc;
    private void Start()
    {
        animator = GetComponent<Animator>();
        orc = GameObject.FindObjectOfType<Orc>();
        orc.orcKingDied += OpenDoor;
    }
    void OpenDoor()
    {
        animator.SetBool("IsDoor", true);
    }
}
