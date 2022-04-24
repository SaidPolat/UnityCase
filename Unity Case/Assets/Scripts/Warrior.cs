using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : SoldierType
{
    public Warrior()
    {
        health = 20;
        damage = 5;
        cost = 50;
    }

    public override void Attack()
    {
        Debug.Log("Warrior attack: Damage = " + damage + " , Health = " + health + " hp");
    }
}
