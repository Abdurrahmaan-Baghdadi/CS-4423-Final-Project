using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garbage : MonoBehaviour
{
    FailScreenController fsc;
    
    void Awake()
    {
        fsc = FailScreenController.failScreenController;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "FishingFloat")
        {
            fsc.OpenFailScreen();
        }
    }

}
