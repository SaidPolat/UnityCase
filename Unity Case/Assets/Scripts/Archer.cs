using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : SoldierType
{

    public int range = 10;
    public int accuracy = 3;

    public Archer()
    {
        health = 15;
        damage = 3;
        cost = 20;
    }

    public override void Attack()
    {
        Debug.Log("Archer attack: Damage = " + damage + " , Range = " + range + " , Accuracy = " + accuracy + " , Health = " + health + " hp");
    }
}
