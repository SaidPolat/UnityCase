using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : SoldierType
{

    public int spellDamage = 10;

    public Mage()  //Base classtan alýnan deðiþkenleri bu classa özel deðerler verebilmek için constructorda deðerler veriyoruz
    {
        health = 10;
        damage = 4;
        cost = 30;
    }

    public override void Attack() //override kullanýyoruz ki bu classa özel deðiþtirebilsin methodu
    {
        Debug.Log("Mage attack: Damage = " + damage + " , Speel Damage = " + spellDamage +  " , Health = " + health + " hp");
    }
}
