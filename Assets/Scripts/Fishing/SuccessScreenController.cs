using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessScreenController : MonoBehaviour
{
    public static SuccessScreenController successScreenController = null;
    public Canvas successScreen;
    FailScreenController fsc;
    void Awake()
    {
        if(successScreenController == null)
        {
            successScreenController = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        fsc = FailScreenController.failScreenController;
        successScreen = GetComponent<Canvas>();
        successScreen.enabled = false;
    }

    public void OpenSuccessScreen()
    {
        if(fsc.failScreen.enabled == false)
            successScreen.enabled = true;
    }
    public void CloseSuccessScreen()
    {
        successScreen.enabled = false;
    }
    
}
