using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static List<SoldierType> troops = new List<SoldierType>(); //askerleri olu�tururken bu listenin i�ine at�yorum

    public int delayAmount = 1; // 1 saniye 
    protected float timer;

    void Start()
    {
        //objelerimizi olu�turuyoruz
        Barrack barrack = new Barrack();
        PowerPlant powerPlant = new PowerPlant();
        BombTower bomb = new BombTower();

        //objeler olu�up attacklar� d�zg�n �al���yor mu kontrol� i�in

        /*Archer archer = new Archer();
        Warrior warrior = new Warrior();
        Mage mage = new Mage();

        archer.Attack();
        warrior.Attack();
        mage.Attack();*/

        //pdf'in i�inde parametre olarak SoldierType verildi�i i�in ba�ka t�rl� bir y�ntem akl�ma gelmedi
        //Class yollayamad���m i�in i�eriye obje yollamam gerekti�inden "new Archer()" tarz�nda obje olu�turup
        //yollamak akl�ma geldi. Umar�m do�ru anlam���md�r :)

        barrack.ProductSoldier(new Archer());
        barrack.ProductSoldier(new Warrior());
        barrack.ProductSoldier(new Mage());
        barrack.ProductSoldier(new Warrior());
        barrack.ProductSoldier(new Mage());
        barrack.ProductSoldier(new Archer());
        barrack.ProductSoldier(new Archer());
        barrack.ProductSoldier(new Archer());
        barrack.ProductSoldier(new Mage());

        foreach (SoldierType type in troops)
        {
            type.Attack();
        }

        //update'den yararland�m ama burda c#'daki timer'� kullanarak da yapabilirdim. Onu yapsayd�m direkt
        //o fonksiyonun i�inde bu i�lemi yapabilirdim ama unity oyunlar�nda timer kullan�lmas�na �ok rastlamad���m i�in
        //ve updatede bunu rahat yapabildi�imiz i�in bu �ekilde yapmay� tercih ettim. Bu yolda PowerPlant.cs dosyas�nda 
        //MonoBehaviour'� base class olarak koyamad���m i�in update'i orda kullanamad�m. Ben de onun yerine buradaki updateden
        //yard�m ald�m. Fonksiyonu �a��rmak bool de�erini de�i�tiriyor ve update i�indeki kod �al��maya ba�l�yor.
        powerPlant.GenerateEnergy();

        bomb.Attack();
    }

    private void Update()
    {
        if (PowerPlant.startGenerate) //PowerPlant.cs i�indeki bool'un kontrol�
        {

            timer += Time.deltaTime;  //zaman� artt�r�yor

            if (timer >= delayAmount)  //1 saniyeye ula�t���nda if e giriyor
            {
                timer = 0f;   //ayn� i�lemi tekrarlamas� i�in timer� s�f�rl�yor

                PowerPlant.totalEnergy += 10;   //10 enerji ekliyoruz ve bu i�lemi her saniye yap�yoruz

                Debug.Log("Energy Count: " + PowerPlant.totalEnergy);
            }
        }
    }
}
