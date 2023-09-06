using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xdirection = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2 (xdirection * speed, rb.velocity.y);

        float ydirection = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, ydirection * speed);
    }
}
