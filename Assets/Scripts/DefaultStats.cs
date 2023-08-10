using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultStats : MonoBehaviour
{
    [SerializeField]
    private ScriptableStats RolosStats;

    [SerializeField]
    private ScriptableCurrency RolosCurrency;

    public void SetDefaultStats()
    {
        RolosStats.RolosMaxHP = 3;
        RolosStats.RolosHP = 3;
        RolosStats.Sharpness = 1;
        RolosStats.Power = 1;

        RolosCurrency.TinyTritonTear = 0;
        RolosCurrency.SeafoamShard = 0;
        RolosCurrency.CoralCrest = 0;
        RolosCurrency.RoyalReef = 0;
    }
}
