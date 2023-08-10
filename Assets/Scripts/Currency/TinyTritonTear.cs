using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TinyTritonTear : MonoBehaviour
{
    Text text;
    [SerializeField]
    private ScriptableCurrency RolosCurrency;
    
    void Awake()
    {
        text = GetComponent<Text>();
    }

    
    void Start()
    {
        
    }

    void Update() 
    {
        text.text = RolosCurrency.TinyTritonTear.ToString();
    }
}
