using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    public string itemName;
    public int itemDamage;
    
    protected bool isOwned;

    public bool GetIsOwned()
    {
        return isOwned;
    }

    public void PickupItem()
    {
        Debug.Log($"Item {itemName} aquired");
        isOwned = true;
    }

    public virtual void Use()
    { }
}
