using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class PlayerMovement : MonoBehaviour
{
    Vector2 move;
    Vector2 vecgravity;
    public int speed = 3;
    public int jump = 5;
    Rigidbody2D rb;
    public Transform GroundCheck;
    public LayerMask GroundLayer;
    bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        vecgravity = new Vector2(0, -Physics2D.gravity.y);
    }

    // Update is called once per frame
    void Update()
    {
      
       move = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));

        transform.Translate(move * speed * Time.deltaTime, Space.Self);
        flip();

       if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }

        isGrounded = Physics2D.OverlapCapsule(GroundCheck.position, new Vector2(1.8f, 0.2f), CapsuleDirection2D.Horizontal, 0 , GroundLayer);
        if (rb.velocity.y < 0)
        {
            rb.velocity -= vecgravity * Time.deltaTime;
        }


    }

    void flip()
    {
        if (move.x < -0.1f) transform.localScale = new Vector3(-1,1,1);
        if (move.x > 0.1f) transform.localScale = new Vector3(1, 1, 1);
    }
}
