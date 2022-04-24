using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static List<SoldierType> troops = new List<SoldierType>(); //askerleri oluþtururken bu listenin içine atýyorum

    public int delayAmount = 1; // 1 saniye 
    protected float timer;

    void Start()
    {
        //objelerimizi oluþturuyoruz
        Barrack barrack = new Barrack();
        PowerPlant powerPlant = new PowerPlant();
        BombTower bomb = new BombTower();

        //objeler oluþup attacklarý düzgün çalýþýyor mu kontrolü için

        /*Archer archer = new Archer();
        Warrior warrior = new Warrior();
        Mage mage = new Mage();

        archer.Attack();
        warrior.Attack();
        mage.Attack();*/

        //pdf'in içinde parametre olarak SoldierType verildiði için baþka türlü bir yöntem aklýma gelmedi
        //Class yollayamadýðým için içeriye obje yollamam gerektiðinden "new Archer()" tarzýnda obje oluþturup
        //yollamak aklýma geldi. Umarým doðru anlamýþýmdýr :)

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

        //update'den yararlandým ama burda c#'daki timer'ý kullanarak da yapabilirdim. Onu yapsaydým direkt
        //o fonksiyonun içinde bu iþlemi yapabilirdim ama unity oyunlarýnda timer kullanýlmasýna çok rastlamadýðým için
        //ve updatede bunu rahat yapabildiðimiz için bu þekilde yapmayý tercih ettim. Bu yolda PowerPlant.cs dosyasýnda 
        //MonoBehaviour'ý base class olarak koyamadýðým için update'i orda kullanamadým. Ben de onun yerine buradaki updateden
        //yardým aldým. Fonksiyonu çaðýrmak bool deðerini deðiþtiriyor ve update içindeki kod çalýþmaya baþlýyor.
        powerPlant.GenerateEnergy();

        bomb.Attack();
    }

    private void Update()
    {
        if (PowerPlant.startGenerate) //PowerPlant.cs içindeki bool'un kontrolü
        {

            timer += Time.deltaTime;  //zamaný arttýrýyor

            if (timer >= delayAmount)  //1 saniyeye ulaþtýðýnda if e giriyor
            {
                timer = 0f;   //ayný iþlemi tekrarlamasý için timerý sýfýrlýyor

                PowerPlant.totalEnergy += 10;   //10 enerji ekliyoruz ve bu iþlemi her saniye yapýyoruz

                Debug.Log("Energy Count: " + PowerPlant.totalEnergy);
            }
        }
    }
}
