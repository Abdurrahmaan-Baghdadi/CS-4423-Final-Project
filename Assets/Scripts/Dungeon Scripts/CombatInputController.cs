using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatInputController : MonoBehaviour
{
    Character player;
    HealthBar healthBar;
    bool hasFired = false;
    bool hasAttacked = false;

    [SerializeField]
    private ScriptableStats RolosStats;
    
    // Start is called before the first frame update
    void Awake()
    {
        player = Character.character;
    }

    void Start()
    {
         
         healthBar = HealthBar.healthBar;
         healthBar.SetMaxHP(RolosStats.RolosMaxHP);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && hasFired == false)
        {
            player.FireEnergyOrb();
            StartCoroutine(DelayProjectile());
        }
        if(Input.GetKeyDown(KeyCode.V) && hasAttacked == false)
        {
            player.Attack();
            StartCoroutine(DelayAttack());
        }
        healthBar.SetHealth(RolosStats.RolosHP);
       
    }

    IEnumerator DelayProjectile()
    {
        hasFired = true;
        yield return new WaitForSeconds(2);
        hasFired = false;
        yield return null;
    }
    IEnumerator DelayAttack()
    {
        hasAttacked = true;
        yield return new WaitForSeconds(0.5f);
        hasAttacked = false;
        yield return null;
    }
}
