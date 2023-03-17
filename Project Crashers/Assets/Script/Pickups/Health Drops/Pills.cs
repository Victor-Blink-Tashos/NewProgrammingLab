using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pills : MonoBehaviour
{
    
    
   

    Pickups pill;

    [SerializeField] Player p;

    private void Awake()
    {
        pill = new Pickups("pills", 0, 5);
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Player")
        {
            p.StartRegen();

            Destroy(gameObject);


        }

    }

    
}
