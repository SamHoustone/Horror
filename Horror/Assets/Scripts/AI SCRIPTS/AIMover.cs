using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIMover : MonoBehaviour
{
    [SerializeField] Transform target;

    NavMeshAgent navMeshAgent;

    Health health;
    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        health = GetComponent<Health>();
    }

    void Update()
    {

        navMeshAgent.enabled = !health.IsDead();


        UpdateAnimator();
    }

    public void StartMoveAction(Vector3 destination)
    {
        GetComponent<ActionScheduler>().StartAction(this);
        GetComponent<Fighter>().Cancel();
        MoveTo(destination);
    }

    public void MoveTo(Vector3 destination)
    {
        GetComponent<NavMeshAgent>().destination = destination;
        navMeshAgent.destination = destination;
        navMeshAgent.isStopped = false;
    }
    public void Stop()
    {
        navMeshAgent.isStopped = true;
    }
    private void UpdateAnimator()
    {
        Vector3 velocity = navMeshAgent.velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;
        GetComponent<Animator>().SetFloat("ForwardSpeed", speed);
    }
}
