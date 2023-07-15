using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShopItem7 : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    // Start is called before the first frame update
    void Awake() 
    {
        text = GetComponent<Text>();
        text.text = "item7";
    }

    public void ChangeItemSeven(string item7)
    {
        text.text = item7;
    }
}

