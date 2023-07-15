using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Item3 : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    // Start is called before the first frame update
    void Awake() 
    {
        text = GetComponent<Text>();
        text.text = "item3";
    }

    public void ChangeItemThree(string item3)
    {
        text.text = item3;
    }
}

