using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    SpriteRenderer sr;
    Rigidbody2D rb;

    public float speed = 2.0f;
    public int TinyTritonTear = 20;
    public int SeafoamShard = 15;
    public int CoralCrest = 10;
    public int RoyalReef = 5;
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
        if(direction == Vector3.zero){
            animationStateController.ChangeAnimationState("RolosIdle");
        }
        else if(rb.velocity.y > 0){
            animationStateController.ChangeAnimationState("RolosUp");
        }
        else if(rb.velocity.y < 0){
            animationStateController.ChangeAnimationState("RolosDown");
        }
        else{
        animationStateController.ChangeAnimationState("RolosWalking", 1.25f);
        }
        if(Mathf.Abs(rb.velocity.x)>0)
        {
            sr.flipX = rb.velocity.x < 0;
        }
        rb.MovePosition(transform.position + (direction*speed*Time.fixedDeltaTime));
    }

    
}
