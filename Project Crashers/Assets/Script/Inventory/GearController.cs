using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearController<T> where T: Gear
{
    private List<T> powerCollection = new List<T>();

    public void AddPower(T item)
    {
        powerCollection.Add(item);
    }


    public T GetPower(string name)
    {
        foreach (T item in powerCollection)
        {
            if (item.itemName == name)
            {
                return item;
            }
        }

        return null;
    }

    public void UsePower(string name)
    {
        foreach (T item in powerCollection)
        {
            if (item.itemName == name)
            {
                item.Use();
            }
        }
    }
}
