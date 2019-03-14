using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    Animator animator;
    Quest quest;
    bool Opendoor;
    private void Start()
    {
        Opendoor = false;
        quest = Quest.instance;
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Opendoor = true;
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
            Opendoor = false;
        }
        Debug.Log(Opendoor);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Opendoor == true)
        {
            if (quest.CurrentProgress >= quest.ListQuest[quest.currentQuest].required)
            {
                animator.SetBool("IsDoor", true);
            }
        }
    }
}
