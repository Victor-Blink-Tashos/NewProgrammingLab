using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{

   

    public string nameCollectable;
    public int score;
    public int restoreHP; 

    public Pickups(string name, int scorevalue, int restoreHPvalue)
    {
        this.nameCollectable = name;
        this.score = scorevalue;
        this.restoreHP = restoreHPvalue;
    }



    public int Heal()
    {
        return restoreHP;
    }

}
