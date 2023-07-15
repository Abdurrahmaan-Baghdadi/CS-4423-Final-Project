using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SeafoamShard : MonoBehaviour
{
    Text text;
    public Character player;
    
    void Awake()
    {
        text = GetComponent<Text>();
    }

    
    void Start()
    {
        player = Character.character;
    }

    void Update() 
    {
        text.text = player.SeafoamShard.ToString();
    }
}

