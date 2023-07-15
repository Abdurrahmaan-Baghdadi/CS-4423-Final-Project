using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShopItem4 : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    // Start is called before the first frame update
    void Awake() 
    {
        text = GetComponent<Text>();
        text.text = "item4";
    }

    public void ChangeItemFour(string item4)
    {
        text.text = item4;
    }
}

