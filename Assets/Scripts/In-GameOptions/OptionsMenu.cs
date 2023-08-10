using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GetComponent<Canvas>().enabled = true;
        }
    }

    public void CloseInGameOptions()
    {
        GetComponent<Canvas>().enabled = false;
    }
}
