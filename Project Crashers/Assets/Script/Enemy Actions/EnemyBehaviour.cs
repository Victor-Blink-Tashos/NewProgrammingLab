using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : EnemyStats
{
    Transform location;
   

    [SerializeField] Transform player;


    public int moveSpeed;
  

    [HideInInspector] [SerializeField] new Renderer renderer;


    public NavMeshAgent agent;

    public LayerMask groundLayer, playerLayer;


    public float timeBetweenAttacks;

    bool alreadyAttacked;

    public GameObject weapon;

    public GameObject weaponPosition;


    public float sightRange, attackRange;

    public bool playerSightRange, playerAttackRange;


   


    private void Reset()
    {
        renderer = GetComponent<MeshRenderer>();

        
    }


    void Start()
    {
        location = GetComponent<Transform>();

        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

       

        if (renderer.isVisible)
        {
            move();
        }
    }


    private void move()
    {

        //Code that makes the enemy follow the player

        if (player.position.x > location.position.x)
        {
            location.position -= transform.right * Time.deltaTime * moveSpeed;
            location.rotation = Quaternion.Euler(0, 180, 0);
        }


        else if (player.position.x < location.position.x)
        {
            location.position -= transform.right * Time.deltaTime * moveSpeed;
            location.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (player.position.z > location.position.z)
        {
            location.position -= transform.right * Time.deltaTime * moveSpeed;
            location.rotation = Quaternion.Euler(0, 90, 0);
        }

        else if (player.position.z < location.position.z)
        {
            location.position -= transform.right * Time.deltaTime * moveSpeed;
            location.rotation = Quaternion.Euler(0, 270, 0);
        }
    }

}
