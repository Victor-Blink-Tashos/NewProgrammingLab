using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] int health;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
       
        
       
    }

    public void StartRegen()
    {
        StartCoroutine(HealthIncrease());
    }


    public void restoreHealth(int heal)
    {
        health += heal;
    }


    public int getHealth()
    {
        return health;
    }

    IEnumerator HealthIncrease()
    {
        for(int i = 1; i <= 5; i++)
        {
            restoreHealth(1);
            yield return new WaitForSeconds(0.5f);
        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Blast Zone")
        {
            health = 0;

        }



       
    }
}
