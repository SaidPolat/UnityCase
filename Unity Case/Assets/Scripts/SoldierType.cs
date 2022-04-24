using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierType 
{
    public int health;
    public int damage;
    public int cost;

    public virtual void Attack()
    {
        Debug.Log("Soldier attacked");
    }
}
