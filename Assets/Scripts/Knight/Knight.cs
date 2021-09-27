using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{

    Rigidbody2D body;

    float horizontal;

    public float runSpeed = 10.0f;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, 0);
    }
}
