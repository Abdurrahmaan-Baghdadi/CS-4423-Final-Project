using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FailScreenController : MonoBehaviour
{
    public static FailScreenController failScreenController = null;
    public Canvas failScreen;
    SuccessScreenController ssc;
    void Awake()
    {
         if(failScreenController == null)
        {
            failScreenController = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    void Start()
    {
        ssc = SuccessScreenController.successScreenController;
        failScreen = GetComponent<Canvas>();
        failScreen.enabled = false;
    }
    // Start is called before the first frame update
    public void OpenFailScreen()
    {
        if(ssc.successScreen.enabled == false)
            failScreen.enabled = true;
    }
    public void CloseFailScreen()
    {
        failScreen.enabled = false;
    }
}
