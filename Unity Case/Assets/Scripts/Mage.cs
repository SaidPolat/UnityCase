using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : SoldierType
{

    public int spellDamage = 10;

    public Mage()  //Base classtan al�nan de�i�kenleri bu classa �zel de�erler verebilmek i�in constructorda de�erler veriyoruz
    {
        health = 10;
        damage = 4;
        cost = 30;
    }

    public override void Attack() //override kullan�yoruz ki bu classa �zel de�i�tirebilsin methodu
    {
        Debug.Log("Mage attack: Damage = " + damage + " , Speel Damage = " + spellDamage +  " , Health = " + health + " hp");
    }
}
