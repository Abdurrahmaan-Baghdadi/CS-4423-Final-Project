using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    SpriteRenderer sr;
    Rigidbody2D rb;

    public float speed = 2.0f;
    public static Boat boat = null;
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        if(boat == null)
         {
            boat = this;
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
        if(Mathf.Abs(rb.velocity.x)>0)
        {
            sr.flipX = rb.velocity.x < 0;
        }
        rb.MovePosition(transform.position + (direction*speed*Time.fixedDeltaTime));
    }
}
