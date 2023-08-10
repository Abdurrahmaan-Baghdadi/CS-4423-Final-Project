using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ScriptableStats : ScriptableObject
{
    [SerializeField]
    private int rolosMaxHP = 3;
    [SerializeField]
    private int rolosHP = 3;
    [SerializeField]
    private int sharpness = 1;
    [SerializeField]
    private int power = 1;

    public int RolosMaxHP
    {
        get{return rolosMaxHP;}
        set{rolosMaxHP = value;}
    }
    
    public int RolosHP
    {
        get{return rolosHP;}
        set{rolosHP = value;}
    }

    public int Sharpness
    {
        get{return sharpness;}
        set{sharpness = value;}
    }

    public int Power
    {
        get{return power;}
        set{power = value;}
    }
}
