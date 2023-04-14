using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory inventory;

    
    public GearController<NonConsumable> nonConsumableItemsController;

    private void Awake()
    {
        if (inventory == null)
        {
            inventory = this;
        }

        CreateInventory();
    }

    public void CreateInventory()
    {       
        nonConsumableItemsController.AddPower(new NonConsumable("Flame", 10));
    }
}
