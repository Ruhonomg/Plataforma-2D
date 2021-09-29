using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{    
    private int costat;
    private Rigidbody2D body;
    private Animator anim;

    public float runSpeed =0.001f;
    public float jumpForce = 0.001f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        costat = 1;
    }
   
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey("right"))
        {
            costat = 1;
            body.velocity = new Vector2(runSpeed, body.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey("left"))
        {
            costat = -1;
            body.velocity = new Vector2(-runSpeed, body.velocity.y);
        }
        else
        {
            body.velocity = new Vector2(0, body.velocity.y);
        }

        if (Input.GetKey(KeyCode.Space) || (Input.GetKey(KeyCode.W)) && CheckGround.isGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, jumpForce);
        }
        transform.localScale = new Vector3(costat, 1, 1);
    }

}
