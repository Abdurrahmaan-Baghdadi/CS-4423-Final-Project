using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Item1 : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Awake() 
    {
        text = GetComponent<Text>();
        text.text = "item1";
    }

    public void ChangeItemOne(string item1)
    {
        text.text = item1;
    }
}
