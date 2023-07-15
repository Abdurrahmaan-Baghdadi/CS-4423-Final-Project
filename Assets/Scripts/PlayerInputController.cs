using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    Character character;
    MainMenuManager sceneChanger;

    bool inShop = false;

    void Awake()
    {
        sceneChanger = GetComponent<MainMenuManager>();
    }
    void Start() 
    {
        character = Character.character;
    }
    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.E) && inShop == true)
        {
            //Debug.Log("EnteringShop");
           sceneChanger.ChangeScene("Shop");
        }
    }
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D))
        {
            character.Move(new Vector3(1,0,0));
        }
        else if(Input.GetKey(KeyCode.A))
        {
            character.Move(new Vector3(-1,0,0));
        }
        else if(Input.GetKey(KeyCode.W))
        {
            character.Move(new Vector3(0,1,0));
        }
        else if(Input.GetKey(KeyCode.S))
        {
            character.Move(new Vector3(0,-1,0));
        }
        else
        {
            character.Move(new Vector3(0,0,0));
        }
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Shop")
        {
        inShop = true;
        }
    }
    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag == "Shop")
        {
        inShop = false;
        }
    }
}


