using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingController : MonoBehaviour
{
    FishingFloat ff;
    // Start is called before the first frame update
    void Awake() 
    {
        ff = GetComponent<FishingFloat>();
    }

    void Update()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D))
        {
            ff.Move(new Vector3(1,0,0));
        }
        else if(Input.GetKey(KeyCode.A))
        {
            ff.Move(new Vector3(-1,0,0));
        }
        else if(Input.GetKey(KeyCode.W))
        {
            ff.Move(new Vector3(0,1,0));
        }
        else if(Input.GetKey(KeyCode.S))
        {
            ff.Move(new Vector3(0,-1,0));
        }
        else
        {
            ff.Move(new Vector3(0,0,0));
        }
    }
}
