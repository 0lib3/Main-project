using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newSpriteBehavior : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed, jumpForce;
    private bool moveleft, moveright;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
        jumpForce = 500f;
        moveleft = false;
        moveright = false;
    }

    public void Jump()
    {
        if (rb.velocity.y == 0)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }

    public void StopMoving()
    {
        moveleft = false;
        moveright = false;
        rb.velocity = Vector2.zero;
    }

    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
        return hit.collider != null;
    }

    // Update is called once per frame
    void Update()
    {
        // Move left when 'A' or left arrow key is pressed -- rotate sprite 180 left
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        // Move right when 'D' or right arrow key is pressed-- rotate sprite 180 right
        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        // Movement stops when neither left nor right key is being pressed
        else
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }

        // Jump when the spacebar is pressed
        if (Input.GetKeyDown("space"))
        {
            Jump();
        }
    }
}
