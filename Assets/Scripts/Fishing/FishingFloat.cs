using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingFloat : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed = 5.0f;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Move(Vector3 direction)
    {
        rb.MovePosition(transform.position + (direction * speed * Time.fixedDeltaTime));
    }
}
