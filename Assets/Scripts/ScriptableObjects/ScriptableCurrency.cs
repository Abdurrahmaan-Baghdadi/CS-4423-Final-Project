using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ScriptableCurrency : ScriptableObject
{
    [SerializeField]
    private int tinyTritonTear = 0;
    [SerializeField]
    private int seafoamShard = 0;
    [SerializeField]
    private int coralCrest = 0;
    [SerializeField]
    private int royalReef = 0;

    public int TinyTritonTear
    {
        get{return tinyTritonTear;}
        set{tinyTritonTear = value;}
    }
    public int SeafoamShard
    {
        get{return seafoamShard;}
        set{seafoamShard = value;}
    }
    public int CoralCrest
    {
        get{return coralCrest;}
        set{coralCrest = value;}
    }
    public int RoyalReef
    {
        get{return royalReef;}
        set{royalReef = value;}
    }

}
