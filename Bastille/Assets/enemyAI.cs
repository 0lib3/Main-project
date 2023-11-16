using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform wallCheck;
    public LayerMask wallLayer;

    private Rigidbody2D rb;
    private bool moveRight = true;
    private const float wallCheckRadius = 0.2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check for collision with the wall
        bool isCollidingWithWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, wallLayer);

        // Flip direction when colliding with the wall
        if (isCollidingWithWall)
        {
            Flip();
        }

        // Move the enemy based on the current direction
        if (moveRight)
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
    }

    void Flip()
    {
        moveRight = !moveRight;
        Vector3 enemyScale = transform.localScale;
        enemyScale.x *= -1;
        transform.localScale = enemyScale;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(wallCheck.position, wallCheckRadius);
    }
}
