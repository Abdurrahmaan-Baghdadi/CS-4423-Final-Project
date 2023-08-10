using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatInputController : MonoBehaviour
{
    Boat boat;
    MainMenuManager sceneChanger;

    bool inFishing = false;
    bool inDungeon = false;
    bool inWayBack = false;

    void Awake()
    {
        sceneChanger = GetComponent<MainMenuManager>();
    }

    // Start is called before the first frame update
    void Start() 
    {
        boat = Boat.boat;
    }

    // Update is called once per frame
    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.E) && inFishing == true)
        {
            //Debug.Log("EnteringShop");
           sceneChanger.ChangeScene("Fishing", "Ocean");
        }
        if(Input.GetKeyDown(KeyCode.E) && inDungeon == true)
        {
            //Debug.Log("EnteringShop");
           sceneChanger.ChangeScene("Dungeon", "Ocean");
        }
        if(Input.GetKeyDown(KeyCode.E) && inWayBack == true)
        {
            //Debug.Log("EnteringShop");
           sceneChanger.ChangeScene("Anumari", "Ocean");
        }
        
    }
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D))
        {
            boat.Move(new Vector3(1,0,0));
        }
        else if(Input.GetKey(KeyCode.A))
        {
            boat.Move(new Vector3(-1,0,0));
        }
        else if(Input.GetKey(KeyCode.W))
        {
            boat.Move(new Vector3(0,1,0));
        }
        else if(Input.GetKey(KeyCode.S))
        {
            boat.Move(new Vector3(0,-1,0));
        }
        else
        {
            boat.Move(new Vector3(0,0,0));
        }
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "FishingSpot")
        {
            inFishing = true;
        }
        else if(other.tag == "Dungeon")
        {
            inDungeon = true;
        }
        else if(other.tag == "WayToAnumari")
        {
            inWayBack = true;
        }
    }
    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag == "FishingSpot")
        {
            inFishing = false;
        }
        else if(other.tag == "Dungeon")
        {
            inDungeon = false;
        }
        else if(other.tag == "WayToAnumari")
        {
            inWayBack = false;
        }
    }
}
