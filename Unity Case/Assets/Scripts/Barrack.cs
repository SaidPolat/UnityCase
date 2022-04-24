using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrack : BuildingType
{
    public Barrack()
    {
        health = 100;
        cost = 1000;
    }

    public void ProductSoldier(SoldierType type)
    {
        GameController.troops.Add(type);  // SoldierType objesi olarak alýnan objeleri direkt troops listesine ekliyoruz
    }    
 
}
