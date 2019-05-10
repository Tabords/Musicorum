using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseSystem : MonoBehaviour
{

    Animator animator;
    Rigidbody rb;
    bool isWalk, isIdle;
    Transform trans;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
       
    }
    private void Update()
    {
        animator.SetBool("isWalk", isWalk);
        animator.SetBool("isIdle", isIdle);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Pointing")
        {
            trans = other.transform.GetComponentInChildren<Transform>();
            transform.LookAt(trans);
            transform.position = Vector3.Lerp(transform.position, trans.position, Time.deltaTime * .3f);
            isIdle = false;
            isWalk = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Pointing")
        {
            isIdle = true;
            isWalk = false;
        }
    }
}
