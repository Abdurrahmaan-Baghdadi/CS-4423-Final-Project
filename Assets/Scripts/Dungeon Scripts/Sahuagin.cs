using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float speed = 1;

    Character character;
    Rigidbody2D rb;
    SpriteRenderer sr;
    Vector3 change;
    public GameObject toOceanPrefab;
    public GameObject tritonTearPrefab;
    public GameObject coralCrestPrefab;
    public GameObject royalReefPrefab;
    public GameObject seafoamShardPrefab;

    float droppedItem;

    public int knockback = -1;
    public int sahuaginHP = 8;

    [SerializeField]
    private ScriptableStats RolosStats;

    void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        character = Character.character;
    }

    // Update is called once per frame
    void Update()
    {

         //rb.velocity.direction = character.transform.position - rb.transform.position;
         //transform.rotation = Quaternion.LookRotation(transform.forward, character.transform.position - rb.transform.position);
        // rb.velocity = transform.up*speed;
        
        change = transform.position - character.transform.position;
        if(Mathf.Abs(change.x)>0)
        {
            sr.flipX = change.x > 0;
        }
        if(sahuaginHP <= 0)
        {
            droppedItem = Random.Range(0f,1f);
            if(droppedItem < .1f)
                Instantiate(royalReefPrefab, new Vector3(0,0,0), Quaternion.identity);
            else if(droppedItem < .25f)
                Instantiate(coralCrestPrefab, new Vector3(0,0,0), Quaternion.identity);
            else if(droppedItem < .5f)
                Instantiate(seafoamShardPrefab, new Vector3(0,0,0), Quaternion.identity);
            else if(droppedItem <= 1f)
                Instantiate(tritonTearPrefab, new Vector3(0,0,0), Quaternion.identity);
            Instantiate(toOceanPrefab, character.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, character.transform.position, 0.08f * speed);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(sr.flipX)
            {
                knockback = 1;
            }
            else
            {
                knockback = -1;
            }
            transform.position = transform.position + knockback * new Vector3(4,0,0);
        }
        if(other.tag == "Projectile")
        {
            sahuaginHP = sahuaginHP - RolosStats.Power;
            StartCoroutine(damageColorDelay(.2f));
        }
        if(other.tag == "SwingAttack")
        {
            sahuaginHP = sahuaginHP - RolosStats.Sharpness;
            StartCoroutine(damageColorDelay(.2f));
        }
    }

    IEnumerator damageColorDelay(float seconds)
    {
        sr.color = new Color(1,0,0);
        yield return new WaitForSeconds(seconds);
        sr.color = new Color(1,1,1);
        yield return null;
    }
}
