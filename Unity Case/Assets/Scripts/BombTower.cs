using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTower : BuildingType
{

    public int damage = 10;
    public int range = 5;

    public BombTower()
    {
        health = 50;
        cost = 200;
    }
    
    public void Attack()
    {
        Debug.Log("Bomb Tower attack: Damage = " + damage + " , Range = " + range +  " , Health = " + health + " hp");
    }
}
