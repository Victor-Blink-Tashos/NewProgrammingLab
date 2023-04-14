using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider o)
    {


        if (o.tag == "Player")
        {

            Inventory.inventory.nonConsumableItemsController.GetPower("Flame");
            Destroy(gameObject);


        }

    }


}
