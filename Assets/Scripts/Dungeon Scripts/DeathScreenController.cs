using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DeathScreenController : MonoBehaviour
{
    public static DeathScreenController deathScreenController = null;
    public Canvas deathScreen;
    bool hasDied = false;

    [SerializeField]
    private ScriptableStats RolosStats;

    void Awake()
    {
        deathScreenController = this;
        
    }

    void Start()
    {
        deathScreen = GetComponent<Canvas>();
        deathScreen.enabled = false;
    }
    void Update()
    {
         if(RolosStats.RolosHP == 0 && hasDied == false)
        {
           hasDied = deathScreenController.OpenDeathScreen();
        }
        if(Input.GetKeyDown(KeyCode.Escape) && hasDied == true)
        {
           deathScreenController.CloseDeathScreen();
        }
    }
    // Start is called before the first frame update
    public bool OpenDeathScreen()
    {
        deathScreen.enabled = true;
        return true;
    }
    public void ReopenDeathScreen()
    {
        if(hasDied == true)
        {
            deathScreen.enabled = true;
        }
        return;
    }
    public void CloseDeathScreen()
    {
        deathScreen.enabled = false;
    }
}
