using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShopItem8 : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    // Start is called before the first frame update
    void Awake() 
    {
        text = GetComponent<Text>();
        text.text = "item8";
    }

    public void ChangeItemEight(string item8)
    {
        text.text = item8;
    }
}

