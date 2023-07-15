using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShopItem9 : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    // Start is called before the first frame update
    void Awake() 
    {
        text = GetComponent<Text>();
        text.text = "item9";
    }

    public void ChangeItemNine(string item9)
    {
        text.text = item9;
    }
}

