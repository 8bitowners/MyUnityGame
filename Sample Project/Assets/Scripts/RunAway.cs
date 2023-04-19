using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RunAway : MonoBehaviour
{
    Animator anim;

    private NavMeshAgent _agent; 

    public GameObject Player;

    public float EnemyDistanceRun = 4.0f;

    public float speed = 2.0f; 
    
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        while (distance < EnemyDistanceRun) {
            anim.SetBool("walkForward", true);
        }

        if (distance < EnemyDistanceRun) {
            Vector3 dirToPlayer = transform.position - Player.transform.position; 

            Vector3 newPos = transform.position + dirToPlayer.normalized;

           // anim.SetBool("WalkForward", true);

            _agent.SetDestination(newPos);
        }   
        
    }
}
