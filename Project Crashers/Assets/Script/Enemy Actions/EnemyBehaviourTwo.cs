using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviourTwo : EnemyStats
{
    Transform location;


    [SerializeField] Transform player;

    public Vector3 walkpoint;

    public int moveSpeed;

    public NavMeshAgent agent;

    public LayerMask groundLayer, playerLayer;


    public float timeBetweenAttacks;

    bool alreadyAttacked;

    public GameObject weapon;

    public GameObject weaponPosition;


    public float sightRange, attackRange;

    public bool playerSightRange, playerAttackRange;

    bool walkpointSet;


    private void Awake()
    {
        agent.GetComponent<NavMeshAgent>();


    }



   


    void Start()
    {
        location = GetComponent<Transform>();

      
    }

    // Update is called once per frame
    void Update()
    {

        playerSightRange = Physics.CheckSphere(transform.position, sightRange, playerLayer);
        playerAttackRange = Physics.CheckSphere(transform.position, attackRange, playerLayer);

        if (!playerSightRange && !playerAttackRange) Patroling();
       // if (playerSightRange && !playerAttackRange) ChasePlayer();
       // if (playerSightRange && playerAttackRange) AttackPlayer();




    }


    private void Patroling()
    {
        if (!walkpointSet)
        {
            searchWalkPoint();
        }

        if (walkpointSet)
        {
            agent.SetDestination(walkpoint);
        }

        Vector3 DistanceToWalkpoint = transform.position - walkpoint;

        if(DistanceToWalkpoint.magnitude < 1f)
        {
            walkpointSet = false;
        }


    }

    private void searchWalkPoint()
    {
       // float randomX = Random.Range(-walkpointRange, walkpointRange);
       // float randomZ = Random.Range(-walkpointRange, walkpointRange);
       // walkpoint = new Vector3(randomX, transform.position.y, randomZ);

       // if(Physics.)
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }


}
