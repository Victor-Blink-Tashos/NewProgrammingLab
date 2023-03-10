using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour
{

    [SerializeField] Transform trans;

    [SerializeField] float moveSpeed;

    [SerializeField] float jumpforce;


    public bool isGrounded;


    private Rigidbody body;




    //[SerializeField] Transform weaponAppear;

    //[SerializeField] float timeToNextShot;


    //[SerializeField] GameObject lightWeapon;
    //[SerializeField] GameObject heavyWeapon;

    //[SerializeField] GameObject spellShot;

    //[SerializeField] float bulletSpeed;
    //[SerializeField] float lightAttackSpeed;
    //[SerializeField] float heavyAttackSpeed;

    //[SerializeField] float bulletDelay;
    //[SerializeField] float lightAttackLag;
    //[SerializeField] float heavyAttackLag;


    //[SerializeField] float landingLag;

    // How fast we want the player to move and spin




    void Start()
    {

        trans = GetComponent<Transform>();

        
        body = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        walk();

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {

            body.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);



        }
    }


    void walk()
    {
        if (Input.GetKey(KeyCode.D)) // detect while walking is the player input
        {
            trans.position += transform.right * Time.deltaTime * moveSpeed; //  Time.deltaTime, it does not depend on the performance of your computer
            trans.rotation = Quaternion.Euler(0, 0, 0); // set the rotation of game object
          
        }
        if (Input.GetKey(KeyCode.A))
        {
            trans.position += transform.right * Time.deltaTime * moveSpeed;
            trans.rotation = Quaternion.Euler(0, 180, 0); //change rotation to 180
            
        }

        if (Input.GetKey(KeyCode.W))
        {
            trans.position += transform.right * Time.deltaTime * moveSpeed;
            trans.rotation = Quaternion.Euler(0, 270, 0); 

        }

        if (Input.GetKey(KeyCode.S))
        {
            trans.position += transform.right * Time.deltaTime * moveSpeed;
            trans.rotation = Quaternion.Euler(0, 90, 0); 

        }




    }

    private void OnCollisionEnter(Collision collision) // detects when the 
                                                       //object collides with another object
    {
        if (collision.collider.tag == "Ground") // saying if the thing you're 
                                                //colliding with has the ground tag on it
        {
            for (int i = 0; i < collision.contacts.Length; i++) // if any one of the 
                                                                //collisions is on the ground
            {

                isGrounded = true;

            }
        }





    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Ground") // saying if the thing you're 
                                                //leaving the object with the ground tag on it
        {
            isGrounded = false;



        }
    }

}
//features yet to be implemented

//void lightAttack()
//{

//}

//void shoot()
//{
//  GameObject newBullet = Instantiate(spellShot, weaponAppear.position + new Vector3(1, 0, 0), this.transform.rotation) as GameObject;

//Rigidbody bulletRB = newBullet.GetComponent<Rigidbody>();
//bulletRB.velocity = this.transform.forward * bulletSpeed;
//}

//bool canShoot()
//{
//if (timeToNextShot < Time.realtimeSinceStartup)
//{
//timeToNextShot = Time.realtimeSinceStartup + bulletDelay;
//return true;
//}
//else
//{
// return false;
//}



//}



