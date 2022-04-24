using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using UnityEngine;

public class PowerPlant : BuildingType
{
    public static int totalEnergy = 0;

    public static bool startGenerate = false;

    public PowerPlant()
    {
        health = 50;
        cost = 250;
    }

    public void GenerateEnergy()
    {
        startGenerate = true;  
        
    }

}
