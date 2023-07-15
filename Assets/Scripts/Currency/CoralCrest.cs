using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoralCrest : MonoBehaviour
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
        text.text = player.CoralCrest.ToString();
    }
}

