using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent (typeof(NavMeshAgent))]
public class NeomorphAI : MonoBehaviour
{
    public Transform target;
    float distance;
    NavMeshAgent myAgent;
    Animator myAnim;
    void Start()
    {
        myAnim = GetComponent<Animator>();
        myAgent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        distance = Vector3.Distance(transform.position, target.transform.position);
        if (distance > 10){
            myAgent.enabled = false;
            myAnim.SetBool("Idle", true);
            myAnim.SetBool("Run", false);
            myAnim.SetBool("Attack", false);
        }

        if (distance <= 5 & distance > 2)
        {
            myAgent.enabled = true;
            myAgent.SetDestination(target.position);
            myAnim.SetBool("Idle", true);
            myAnim.SetBool("Run", false);
            myAnim.SetBool("Attack", false);
        }

        if (distance <= 1.5)
        {
            myAgent.enabled = false;
            myAnim.SetBool("Idle", false);
            myAnim.SetBool("Run", false);
            myAnim.SetBool("Attack", true);
        }
    }
}
