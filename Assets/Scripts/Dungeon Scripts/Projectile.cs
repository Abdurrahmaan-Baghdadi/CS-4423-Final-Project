using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 3.5f;

    Rigidbody2D rb;
    SpriteRenderer sr;

    public Color defaultShade = Color.blue;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        SetColor(defaultShade);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireProjectile(Vector3 position)
    {
        transform.rotation = Quaternion.LookRotation(transform.forward, position - transform.position);
        rb.velocity = transform.up * speed;
    }
    
    public void SetColor(Color shade)
    {
        sr.color = shade;
    }
}
