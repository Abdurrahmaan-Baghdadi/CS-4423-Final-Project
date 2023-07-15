using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Item2 : MonoBehaviour
{
    // Start is called before the first frame update
  Text text;
    // Start is called before the first frame update
    void Awake() 
    {
        text = GetComponent<Text>();
        text.text = "item2";
    }

    public void ChangeItemTwo(string item2)
    {
        text.text = item2;
    }
}

