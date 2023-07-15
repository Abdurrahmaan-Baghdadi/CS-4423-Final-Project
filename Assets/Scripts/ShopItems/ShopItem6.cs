using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShopItem6 : MonoBehaviour
{
    // Start is called before the first frame update
   Text text;
    // Start is called before the first frame update
    void Awake() 
    {
        text = GetComponent<Text>();
        text.text = "item6";
    }

    public void ChangeItemSix(string item6)
    {
        text.text = item6;
    }
}
