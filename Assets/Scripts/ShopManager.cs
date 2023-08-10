using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField]
    private ScriptableStats RolosStats;

    [SerializeField]
    private ScriptableCurrency RolosCurrency;

    public void SharpnessI()
    {
        if(RolosCurrency.TinyTritonTear >= 1 && RolosStats.Sharpness < 2)
        {
            RolosCurrency.TinyTritonTear -= 1;
            RolosStats.Sharpness = 2;
        }
    }
    public void SharpnessII()
    {
        if(RolosCurrency.CoralCrest >= 1 && RolosStats.Sharpness < 3)
        {
            RolosCurrency.CoralCrest -= 1;
            RolosStats.Sharpness = 3;
        }
    }
    public void SharpnessIII()
    {
        if(RolosCurrency.RoyalReef >= 1 && RolosStats.Sharpness < 4)
        {
            RolosCurrency.RoyalReef -= 1;
            RolosStats.Sharpness = 4;
        }
    }
    public void PowerI()
    {
        if(RolosCurrency.TinyTritonTear >= 1 && RolosStats.Power < 2)
        {
            RolosCurrency.TinyTritonTear -= 1;
            RolosStats.Power = 2;
        }
    }
    public void PowerII()
    {
        if(RolosCurrency.SeafoamShard >= 1 && RolosStats.Power < 3)
        {
            RolosCurrency.SeafoamShard -= 1;
            RolosStats.Power = 3;
        }
    }
    public void PowerIII()
    {
        if(RolosCurrency.RoyalReef >= 1 && RolosStats.Power < 4)
        {
            RolosCurrency.RoyalReef -= 1;
            RolosStats.Power = 4;
        }
    }
    public void HealthI()
    {
        if(RolosCurrency.SeafoamShard >= 1 && RolosStats.RolosMaxHP < 4)
        {
            RolosCurrency.SeafoamShard -= 1;
            RolosStats.RolosMaxHP = 4;
        }
    }
    public void HealthII()
    {
        if(RolosCurrency.CoralCrest >= 1 && RolosStats.RolosMaxHP < 5)
        {
            RolosCurrency.CoralCrest -= 1;
            RolosStats.RolosMaxHP = 5;
        }
    }
    public void HealthIII()
    {
        if(RolosCurrency.CoralCrest >= 1 && RolosStats.RolosMaxHP < 6)
        {
            RolosCurrency.CoralCrest -= 1;
            RolosStats.RolosMaxHP = 6;
        }
    }

}
