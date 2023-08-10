using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    SpriteRenderer sr;
    Rigidbody2D rb;

    public GameObject attackPrefab;
    public GameObject projectilePrefab;
    int attackDirection;

    public bool isAttacking = false;
    public bool hasTakenDamage = false;

    public float speed = 2.0f;
    

    [SerializeField]
    private ScriptableStats RolosStats;

    [SerializeField]
    private ScriptableCurrency RolosCurrency;
    
    public static Character character = null;
    AnimationStateController animationStateController;

    void Awake() {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        animationStateController = GetComponent<AnimationStateController>();
        if(character == null)
        {
            character = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Vector3 direction)
    {
        rb.velocity = direction*speed;
        if(direction == Vector3.zero && isAttacking == false){
            animationStateController.ChangeAnimationState("RolosIdle");
        }
        else if(rb.velocity.y > 0 && isAttacking == false){
            animationStateController.ChangeAnimationState("RolosUp");
        }
        else if(rb.velocity.y < 0 && isAttacking == false){
            animationStateController.ChangeAnimationState("RolosDown");
        }
        else if(isAttacking == false)
        {
        animationStateController.ChangeAnimationState("RolosWalking", 1.25f);
        }
        if(Mathf.Abs(rb.velocity.x)>0)
        {
            sr.flipX = rb.velocity.x < 0;
            attackPrefab.GetComponent<SpriteRenderer>().flipX =  rb.velocity.x < 0;
        }
        rb.MovePosition(transform.position + (direction*speed*Time.fixedDeltaTime));
    }

    public void Attack()
    {
        
        animationStateController.ChangeAnimationState("RolosAttack");
        if(sr.flipX)
        {
           attackDirection = -1;
        }
        else
        {
            attackDirection = 1;
        }
        GameObject newSwingAttack = Instantiate(attackPrefab, transform.position + new Vector3(attackDirection*1,0,0), Quaternion.identity);
        Destroy(newSwingAttack, .1f);
        StartCoroutine(DelayAttack(.2f));
        
    }

    public void FireEnergyOrb()
    {
        GameObject newEnergyOrb= Instantiate(projectilePrefab, transform.position, Quaternion.identity);
       newEnergyOrb.GetComponent<Projectile>().FireProjectile(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Destroy(newEnergyOrb, 10);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Sahuagin" && RolosStats.RolosHP > 0 && hasTakenDamage == false)
        {
            RolosStats.RolosHP -= 1;
            StartCoroutine(DelayDamage(0.5f));
        }
        if(other.tag == "TinyTritonTear")
        {
            RolosCurrency.TinyTritonTear +=1;
        }
        if(other.tag == "SeafoamShard")
        {
            RolosCurrency.SeafoamShard +=1;
        }
        if(other.tag == "CoralCrest")
        {
            RolosCurrency.CoralCrest +=1;
        }
        if(other.tag == "RoyalReef")
        {
            RolosCurrency.RoyalReef +=1;
        }
    }

    private IEnumerator DelayAttack(float seconds)
    {
        isAttacking = true;
        yield return new WaitForSeconds(seconds);
        isAttacking = false;
        yield return null;
    }

    private IEnumerator DelayDamage(float seconds)
    {
        hasTakenDamage = true;
        yield return new WaitForSeconds(seconds);
        hasTakenDamage = false;
        yield return null;
    }
    
}
