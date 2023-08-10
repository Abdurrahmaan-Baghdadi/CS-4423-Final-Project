using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    SuccessScreenController ssc;

    [SerializeField]
    private ScriptableStats RolosStats;
    
    void Awake()
    {
        ssc = SuccessScreenController.successScreenController;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "FishingFloat")
        {
            if(RolosStats.RolosHP < RolosStats.RolosMaxHP)
                RolosStats.RolosHP += 1;
            ssc.OpenSuccessScreen();
        }
    }
}
